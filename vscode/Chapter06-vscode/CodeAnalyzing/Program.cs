using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1200:UsingDirectivesMustBePlacedWithinNamespace", Justification = "Reviewed.")]

namespace CodeAnalyzing;

class Program
{
    static void Main(string[] args)
    {
        Debug.WriteLine("Hello, Debugger!");
    }
}
