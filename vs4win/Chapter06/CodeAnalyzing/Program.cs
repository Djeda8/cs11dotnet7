// #pragma warning disable SA1200 // UsingDirectivesMustBePlacedWithinNamespace
// #pragma warning restore SA1200 // UsingDirectivesMustBePlacedWithinNamespace
// using System.Diagnostics.CodeAnalysis;

// [assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1200:UsingDirectivesMustBePlacedWithinNamespace", Justification = "Reviewed.")]

// <copyright file="Program.cs" company="Packt">
// Copyright (c) Packt. All rights reserved.
// </copyright>
namespace CodeAnalyzing;

using System.Diagnostics;

/// <summary>
/// The main class for this console app.
/// </summary>
internal class Program
{
    /// <summary>
    /// The main entry point for this console app.
    /// </summary>
    /// <param name="args">
    /// A string array of arguments passed to the console app.
    /// </param>
    static void Main(string[] args)
    {
        Debug.WriteLine("Hello, Debugger!");
    }
}