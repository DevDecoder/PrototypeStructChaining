using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Silk.Net.Vulkan;
using Xunit;

namespace PrototypeStructChaining.Test;

public class TestCompilation
{
    private static readonly Lazy<IReadOnlyList<MetadataReference>> References = new(() =>
        ((string?) AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") ?? string.Empty)
        .Split(Path.PathSeparator)
        .Select(r => MetadataReference.CreateFromFile(r))
        .Concat(new[] {MetadataReference.CreateFromFile(typeof(StructureType).Assembly.Location)})
        .ToArray()
    );

    private static readonly string CodeTemplate = @"
using System;
using Silk.Net.Vulkan;

public class Test
{{
    public void DoTest()
    {{
        {0}
    }}
}}";

    private IReadOnlyList<Diagnostic> CheckCompile(string code)
    {
        var assemblyName = Path.GetRandomFileName();
        var compilation = CSharpCompilation.Create(
            assemblyName,
            new[] {CSharpSyntaxTree.ParseText(string.Format(CodeTemplate, code))},
            References.Value,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        using var ms = new MemoryStream();
        var result = compilation.Emit(ms);

        if (result.Success)
            return Array.Empty<Diagnostic>();

        return result.Diagnostics.Where(diagnostic =>
                diagnostic.IsWarningAsError ||
                diagnostic.Severity == DiagnosticSeverity.Error)
            .ToArray();
    }

    [Fact]
    public unsafe void TestCantAddUnsupportedNext()
    {
        var diagnostics = CheckCompile(
            @"PhysicalDeviceFeatures2
            .Chain(out var features2)
            .AddNext(out DeviceCreateInfo createInfo);");

        Assert.Single(diagnostics);
        var error = diagnostics.First();
        // error CS0315: The type 'Silk.Net.Vulkan.PhysicalDeviceFeatures2' cannot be used as type parameter 'TChain' in the generic type or method 'ChainExtensions.AddNext<TChain, TNext>(ref TChain, out TNext)'. There is no boxing conversion from 'Silk.Net.Vulkan.PhysicalDeviceFeatures2' to 'Silk.Net.Vulkan.IChainable<Silk.Net.Vulkan.DeviceCreateInfo>'.
        Assert.Equal("CS0315", error.Id);
    }

    [Fact]
    public unsafe void TestCanAddSupportedNext()
    {
        var diagnostics = CheckCompile(
            @"DeviceCreateInfo
            .Chain(out var createInfo)
            .AddNext(out PhysicalDeviceFeatures2 features2);");

        Assert.Empty(diagnostics);
    }
}