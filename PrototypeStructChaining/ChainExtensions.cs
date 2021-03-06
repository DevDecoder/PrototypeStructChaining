using System.Runtime.CompilerServices;

namespace Silk.Net.Vulkan;

public static class ChainExtensions
{
    /// <summary>
    /// Replaces a structure in the chain (if present, and <paramref name="alwaysAdd"/> is false), or adds it to the end.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="value">A reference to the structure to update</param>
    /// <param name="alwaysAdd">Always adds to the end of the chain, even if an equivalent structure is present.</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>A reference to the value value in the chain</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the supplied value will have their `SType` correctly set.  Further,
    /// the supplied structure's <see cref="IChainable.PNext"/> will be overwritten.</para>
    /// <para>To use</para>
    /// <code>
    /// var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
    /// {
    ///     ShaderInputAttachmentArrayDynamicIndexing = true
    /// };
    /// var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR
    /// {
    ///     AccelerationStructure = true
    /// };
    /// 
    /// PhysicalDeviceFeatures2
    ///     .Chain(out var features2)
    ///     .SetNext(ref indexingFeatures)
    ///     .SetNext(ref accelerationStructureFeaturesKhr);
    /// </code>
    /// </remarks>
    public static unsafe ref TChain SetNext<TChain, TNext>(this ref TChain chain, ref TNext value,
        bool alwaysAdd = false)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
    {
        // Ensure structure type of chain and value are set.
        chain.StructureType();
        var structureType = value.StructureType();

        // Find end of chain
        var previousPtr = (Chain*) null;
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        var valuePtr = (Chain*) Unsafe.AsPointer(ref value);
        do
        {
            var nextPtr = currentPtr->PNext;
            if (!alwaysAdd && currentPtr->SType == structureType)
            {
                // We have an existing structure, replace it.
                if (previousPtr is not null) previousPtr->PNext = valuePtr;
                valuePtr->PNext = nextPtr;

                return ref chain;
            }

            previousPtr = currentPtr;
            currentPtr = nextPtr;
        } while (currentPtr is not null);

        // Add value to end of chain
        previousPtr->PNext = valuePtr;
        valuePtr->PNext = null;

        return ref chain;
    }

    /// <summary>
    /// Returns the index of the <paramref name="value"/> in the <paramref name="chain"/>, if present.
    /// </summary>
    /// <param name="chain">The chain</param>
    /// <param name="value">The structure value</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>The zero-indexed index if found; otherwise -1.</returns>
    public static unsafe int IndexOf<TChain, TNext>(this ref TChain chain, ref TNext value)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
    {
        // Ensure structure type of chain is set.
        chain.StructureType();

        var index = 0;
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        var valuePtr = (Chain*) Unsafe.AsPointer(ref value);
        // Follow chain
        do
        {
            if (currentPtr == valuePtr)
                return index;
            currentPtr = currentPtr->PNext;
            index++;
        } while (currentPtr is not null);

        return -1;
    }

    /// <summary>
    /// Adds a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .Chain(out var features2)
    ///     .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    ///     .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);
    /// </code>
    /// <para>Note, the value is always added, even if an equivalent value is added in the chain already.  Use
    /// <see cref="TryAddNext{TChain,TNext}"/> to only add if not already present.</para>
    /// </remarks>
    public static unsafe ref TChain AddNext<TChain, TNext>(this ref TChain chain, out TNext next)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
    {
        // Ensure structure type of chain is set.
        chain.StructureType();

        // Find end of chain
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        while (currentPtr->PNext is not null) currentPtr = currentPtr->PNext;

        // Create new entry and set it's structure type
        next = default;
        next.StructureType();
        currentPtr->PNext = (Chain*) Unsafe.AsPointer(ref next);
        return ref chain;
    }

    /// <summary>
    /// Tries to add a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <param name="added">Whether the structure was actually added</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .Chain(out var features2)
    ///     .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures, out var added);
    /// </code>
    /// </remarks>
    public static unsafe ref TChain TryAddNext<TChain, TNext>(this ref TChain chain, out TNext next, out bool added)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
    {
        // Ensure structure type of chain is set.
        chain.StructureType();

        // Create new entry and get it's structure type
        next = default;
        var structureType = next.StructureType();

        // Follow chain
        var currentPtr = (Chain*) Unsafe.AsPointer(ref chain);
        do
        {
            if (currentPtr->SType == structureType)
            {
                added = false;
                return ref chain;
            }

            var nextPtr = currentPtr->PNext;
            if (nextPtr is null) break;
            currentPtr = nextPtr;
        } while (true);

        currentPtr->PNext = (Chain*) Unsafe.AsPointer(ref next);
        added = true;
        return ref chain;
    }
}