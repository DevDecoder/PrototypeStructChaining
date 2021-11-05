using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.Net.Vulkan;

/// <summary>
///  Static class for creating Managed Chains.
/// </summary>
public static class ManagedChain
{
    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    public static ManagedChain<TChain, T1> Create<TChain, T1>(TChain head = default, T1 item1 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
    {
        return new(head, item1);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items.</returns>
    public static ManagedChain<TChain, T1, T2> Create<TChain, T1, T2>(TChain head = default, T1 item1 = default, T2 item2 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3> Create<TChain, T1, T2, T3>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4> Create<TChain, T1, T2, T3, T4>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5> Create<TChain, T1, T2, T3, T4, T5>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6> Create<TChain, T1, T2, T3, T4, T5, T6>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> Create<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <typeparam name="T15">Type of Item 15.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    public static ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        where T2 : struct, IExtendsChain<TChain>
        where T3 : struct, IExtendsChain<TChain>
        where T4 : struct, IExtendsChain<TChain>
        where T5 : struct, IExtendsChain<TChain>
        where T6 : struct, IExtendsChain<TChain>
        where T7 : struct, IExtendsChain<TChain>
        where T8 : struct, IExtendsChain<TChain>
        where T9 : struct, IExtendsChain<TChain>
        where T10 : struct, IExtendsChain<TChain>
        where T11 : struct, IExtendsChain<TChain>
        where T12 : struct, IExtendsChain<TChain>
        where T13 : struct, IExtendsChain<TChain>
        where T14 : struct, IExtendsChain<TChain>
        where T15 : struct, IExtendsChain<TChain>
    {
        return new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);
    }

}

/// <summary>
/// A <see cref="ManagedChain{TChain, T1}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
public unsafe class ManagedChain<TChain, T1> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    public ManagedChain(TChain head = default, T1 item1 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size + item9Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size + item9Size + item10Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size + item9Size + item10Size + item11Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size + item9Size + item10Size + item11Size + item12Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
    where T13 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item13Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item13Ptr => (Chain*) _item13Ptr;

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>((Chain*) _item13Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item13Ptr)->PNext;
            Marshal.StructureToPtr(value, _item13Ptr, true);
            ((Chain*) _item13Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size + item9Size + item10Size + item11Size + item12Size + item13Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        item13.StructureType();
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);
        var item13Ptr = Interlocked.Exchange(ref _item13Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item13Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
/// <typeparam name="T14">Type of Item 14.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
    where T13 : struct, IExtendsChain<TChain>
    where T14 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item13Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item13Ptr => (Chain*) _item13Ptr;

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>((Chain*) _item13Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item13Ptr)->PNext;
            Marshal.StructureToPtr(value, _item13Ptr, true);
            ((Chain*) _item13Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item14Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item14Ptr => (Chain*) _item14Ptr;

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>((Chain*) _item14Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item14Ptr)->PNext;
            Marshal.StructureToPtr(value, _item14Ptr, true);
            ((Chain*) _item14Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();
        var item14Size = Marshal.SizeOf<T14>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size + item9Size + item10Size + item11Size + item12Size + item13Size + item14Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        item13.StructureType();
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        item14.StructureType();
        Marshal.StructureToPtr(item14, _item14Ptr, false);
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);
        var item13Ptr = Interlocked.Exchange(ref _item13Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item13Ptr);
        var item14Ptr = Interlocked.Exchange(ref _item14Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item14Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
/// <summary>
/// A <see cref="ManagedChain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
/// <typeparam name="T14">Type of Item 14.</typeparam>
/// <typeparam name="T15">Type of Item 15.</typeparam>
public unsafe class ManagedChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IDisposable
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
    where T2 : struct, IExtendsChain<TChain>
    where T3 : struct, IExtendsChain<TChain>
    where T4 : struct, IExtendsChain<TChain>
    where T5 : struct, IExtendsChain<TChain>
    where T6 : struct, IExtendsChain<TChain>
    where T7 : struct, IExtendsChain<TChain>
    where T8 : struct, IExtendsChain<TChain>
    where T9 : struct, IExtendsChain<TChain>
    where T10 : struct, IExtendsChain<TChain>
    where T11 : struct, IExtendsChain<TChain>
    where T12 : struct, IExtendsChain<TChain>
    where T13 : struct, IExtendsChain<TChain>
    where T14 : struct, IExtendsChain<TChain>
    where T15 : struct, IExtendsChain<TChain>
{
    private IntPtr _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _headPtr)->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ((Chain*) _headPtr)->PNext = nextPtr;
        }
    }

    private IntPtr _item1Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) _item1Ptr;

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>((Chain*) _item1Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item1Ptr)->PNext;
            Marshal.StructureToPtr(value, _item1Ptr, true);
            ((Chain*) _item1Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item2Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item2Ptr => (Chain*) _item2Ptr;

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>((Chain*) _item2Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item2Ptr)->PNext;
            Marshal.StructureToPtr(value, _item2Ptr, true);
            ((Chain*) _item2Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item3Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item3Ptr => (Chain*) _item3Ptr;

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>((Chain*) _item3Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item3Ptr)->PNext;
            Marshal.StructureToPtr(value, _item3Ptr, true);
            ((Chain*) _item3Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item4Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item4Ptr => (Chain*) _item4Ptr;

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>((Chain*) _item4Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item4Ptr)->PNext;
            Marshal.StructureToPtr(value, _item4Ptr, true);
            ((Chain*) _item4Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item5Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item5Ptr => (Chain*) _item5Ptr;

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>((Chain*) _item5Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item5Ptr)->PNext;
            Marshal.StructureToPtr(value, _item5Ptr, true);
            ((Chain*) _item5Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item6Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item6Ptr => (Chain*) _item6Ptr;

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>((Chain*) _item6Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item6Ptr)->PNext;
            Marshal.StructureToPtr(value, _item6Ptr, true);
            ((Chain*) _item6Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item7Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item7Ptr => (Chain*) _item7Ptr;

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>((Chain*) _item7Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item7Ptr)->PNext;
            Marshal.StructureToPtr(value, _item7Ptr, true);
            ((Chain*) _item7Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item8Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item8Ptr => (Chain*) _item8Ptr;

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>((Chain*) _item8Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item8Ptr)->PNext;
            Marshal.StructureToPtr(value, _item8Ptr, true);
            ((Chain*) _item8Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item9Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item9Ptr => (Chain*) _item9Ptr;

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>((Chain*) _item9Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item9Ptr)->PNext;
            Marshal.StructureToPtr(value, _item9Ptr, true);
            ((Chain*) _item9Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item10Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item10Ptr => (Chain*) _item10Ptr;

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>((Chain*) _item10Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item10Ptr)->PNext;
            Marshal.StructureToPtr(value, _item10Ptr, true);
            ((Chain*) _item10Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item11Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item11Ptr => (Chain*) _item11Ptr;

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>((Chain*) _item11Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item11Ptr)->PNext;
            Marshal.StructureToPtr(value, _item11Ptr, true);
            ((Chain*) _item11Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item12Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item12Ptr => (Chain*) _item12Ptr;

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>((Chain*) _item12Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item12Ptr)->PNext;
            Marshal.StructureToPtr(value, _item12Ptr, true);
            ((Chain*) _item12Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item13Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item13Ptr => (Chain*) _item13Ptr;

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>((Chain*) _item13Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item13Ptr)->PNext;
            Marshal.StructureToPtr(value, _item13Ptr, true);
            ((Chain*) _item13Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item14Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item14Ptr => (Chain*) _item14Ptr;

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>((Chain*) _item14Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item14Ptr)->PNext;
            Marshal.StructureToPtr(value, _item14Ptr, true);
            ((Chain*) _item14Ptr)->PNext = nextPtr;
        }
    }
    private IntPtr _item15Ptr;

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item15Ptr => (Chain*) _item15Ptr;

    /// <summary>
    /// Gets or sets item #15 in the chain.
    /// </summary>
    public T15 Item15
    {
        get => Unsafe.AsRef<T15>((Chain*) _item15Ptr);
        set
        {
            value.StructureType();
            var nextPtr = ((Chain*) _item15Ptr)->PNext;
            Marshal.StructureToPtr(value, _item15Ptr, true);
            ((Chain*) _item15Ptr)->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain,T1,T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    public ManagedChain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
    {
        // Calculate memory requirements
        var headSize = Marshal.SizeOf<TChain>();
        var item1Size = Marshal.SizeOf<T1>();
        var item2Size = Marshal.SizeOf<T2>();
        var item3Size = Marshal.SizeOf<T3>();
        var item4Size = Marshal.SizeOf<T4>();
        var item5Size = Marshal.SizeOf<T5>();
        var item6Size = Marshal.SizeOf<T6>();
        var item7Size = Marshal.SizeOf<T7>();
        var item8Size = Marshal.SizeOf<T8>();
        var item9Size = Marshal.SizeOf<T9>();
        var item10Size = Marshal.SizeOf<T10>();
        var item11Size = Marshal.SizeOf<T11>();
        var item12Size = Marshal.SizeOf<T12>();
        var item13Size = Marshal.SizeOf<T13>();
        var item14Size = Marshal.SizeOf<T14>();
        var item15Size = Marshal.SizeOf<T15>();

        _headPtr = Marshal.AllocHGlobal(headSize + item1Size + item2Size + item3Size + item4Size + item5Size + item6Size + item7Size + item8Size + item9Size + item10Size + item11Size + item12Size + item13Size + item14Size + item15Size);
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);

        _item1Ptr = _headPtr + headSize;
        item1.StructureType();
        Marshal.StructureToPtr(item1, _item1Ptr, false);
        ((Chain*) _headPtr)->PNext = (Chain*) _item1Ptr;

        _item2Ptr = _item1Ptr + item1Size;
        item2.StructureType();
        Marshal.StructureToPtr(item2, _item2Ptr, false);
        ((Chain*) _item1Ptr)->PNext = (Chain*) _item2Ptr;

        _item3Ptr = _item2Ptr + item2Size;
        item3.StructureType();
        Marshal.StructureToPtr(item3, _item3Ptr, false);
        ((Chain*) _item2Ptr)->PNext = (Chain*) _item3Ptr;

        _item4Ptr = _item3Ptr + item3Size;
        item4.StructureType();
        Marshal.StructureToPtr(item4, _item4Ptr, false);
        ((Chain*) _item3Ptr)->PNext = (Chain*) _item4Ptr;

        _item5Ptr = _item4Ptr + item4Size;
        item5.StructureType();
        Marshal.StructureToPtr(item5, _item5Ptr, false);
        ((Chain*) _item4Ptr)->PNext = (Chain*) _item5Ptr;

        _item6Ptr = _item5Ptr + item5Size;
        item6.StructureType();
        Marshal.StructureToPtr(item6, _item6Ptr, false);
        ((Chain*) _item5Ptr)->PNext = (Chain*) _item6Ptr;

        _item7Ptr = _item6Ptr + item6Size;
        item7.StructureType();
        Marshal.StructureToPtr(item7, _item7Ptr, false);
        ((Chain*) _item6Ptr)->PNext = (Chain*) _item7Ptr;

        _item8Ptr = _item7Ptr + item7Size;
        item8.StructureType();
        Marshal.StructureToPtr(item8, _item8Ptr, false);
        ((Chain*) _item7Ptr)->PNext = (Chain*) _item8Ptr;

        _item9Ptr = _item8Ptr + item8Size;
        item9.StructureType();
        Marshal.StructureToPtr(item9, _item9Ptr, false);
        ((Chain*) _item8Ptr)->PNext = (Chain*) _item9Ptr;

        _item10Ptr = _item9Ptr + item9Size;
        item10.StructureType();
        Marshal.StructureToPtr(item10, _item10Ptr, false);
        ((Chain*) _item9Ptr)->PNext = (Chain*) _item10Ptr;

        _item11Ptr = _item10Ptr + item10Size;
        item11.StructureType();
        Marshal.StructureToPtr(item11, _item11Ptr, false);
        ((Chain*) _item10Ptr)->PNext = (Chain*) _item11Ptr;

        _item12Ptr = _item11Ptr + item11Size;
        item12.StructureType();
        Marshal.StructureToPtr(item12, _item12Ptr, false);
        ((Chain*) _item11Ptr)->PNext = (Chain*) _item12Ptr;

        _item13Ptr = _item12Ptr + item12Size;
        item13.StructureType();
        Marshal.StructureToPtr(item13, _item13Ptr, false);
        ((Chain*) _item12Ptr)->PNext = (Chain*) _item13Ptr;

        _item14Ptr = _item13Ptr + item13Size;
        item14.StructureType();
        Marshal.StructureToPtr(item14, _item14Ptr, false);
        ((Chain*) _item13Ptr)->PNext = (Chain*) _item14Ptr;

        _item15Ptr = _item14Ptr + item14Size;
        item15.StructureType();
        Marshal.StructureToPtr(item15, _item15Ptr, false);
        ((Chain*) _item14Ptr)->PNext = (Chain*) _item15Ptr;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, IntPtr.Zero);
        if (headPtr == IntPtr.Zero) return;

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        var item1Ptr = Interlocked.Exchange(ref _item1Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item1Ptr);
        var item2Ptr = Interlocked.Exchange(ref _item2Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item2Ptr);
        var item3Ptr = Interlocked.Exchange(ref _item3Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item3Ptr);
        var item4Ptr = Interlocked.Exchange(ref _item4Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item4Ptr);
        var item5Ptr = Interlocked.Exchange(ref _item5Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item5Ptr);
        var item6Ptr = Interlocked.Exchange(ref _item6Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item6Ptr);
        var item7Ptr = Interlocked.Exchange(ref _item7Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item7Ptr);
        var item8Ptr = Interlocked.Exchange(ref _item8Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item8Ptr);
        var item9Ptr = Interlocked.Exchange(ref _item9Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item9Ptr);
        var item10Ptr = Interlocked.Exchange(ref _item10Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item10Ptr);
        var item11Ptr = Interlocked.Exchange(ref _item11Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item11Ptr);
        var item12Ptr = Interlocked.Exchange(ref _item12Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item12Ptr);
        var item13Ptr = Interlocked.Exchange(ref _item13Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item13Ptr);
        var item14Ptr = Interlocked.Exchange(ref _item14Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item14Ptr);
        var item15Ptr = Interlocked.Exchange(ref _item15Ptr, IntPtr.Zero);
        Marshal.DestroyStructure<TChain>(item15Ptr);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
