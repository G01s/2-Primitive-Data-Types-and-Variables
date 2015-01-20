using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char symbol = '\u00A9';
        Console.WriteLine("    {0}", symbol);
        Console.WriteLine();
        Console.WriteLine("   {0} {1}", symbol, symbol);
        Console.WriteLine();
        Console.WriteLine("  {0}   {1}", symbol, symbol);
        Console.WriteLine();
        Console.WriteLine(" {0} {1} {2} {3}", symbol, symbol, symbol, symbol);
    }
}