
using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstVariable = "Hello";
        string secondVariable = "World";
        object objectVariable = firstVariable + " " + secondVariable;
        string thirdVariable = objectVariable.ToString();
        Console.WriteLine(thirdVariable);
    }
}
