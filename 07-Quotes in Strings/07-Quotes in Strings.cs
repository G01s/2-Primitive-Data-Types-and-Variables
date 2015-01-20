using System;

class QuotesInStrings
{
    static void Main()
    {
        string strVarOne = "The \"use\" of quotations causes difficulties.";
        string strVarTwo = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(strVarOne);
        Console.WriteLine(strVarTwo);
    }
}