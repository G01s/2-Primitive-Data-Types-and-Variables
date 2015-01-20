
using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter the first floating point number :");
        Decimal first = Decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second floating point number :");
        Decimal second = Decimal.Parse(Console.ReadLine());

        Decimal difference = Math.Abs(first - second);
        Decimal eps = 0.000001m;

        bool notEqual = difference >= eps;
        bool greater = first > second;

        Console.WriteLine(notEqual ?
            "The numbers are NOT equal" :
            "The numbers are equal");

        if (notEqual)
        {
            Console.WriteLine(greater ?
                "{0} is bigger than {1}" :
                "{1} is bigger than {0}"
                , first, second);
        }
    }
}