using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNullValue = null;
        double? doubleNullValue = null;
        Console.WriteLine("Here is result of int null value - {0} and null value for double - {1}", intNullValue, doubleNullValue);
        intNullValue = 5;
        doubleNullValue = 18;
        Console.WriteLine("Here is result of int with a value - {0} and double with a value - {1}", intNullValue.GetValueOrDefault(), doubleNullValue.GetValueOrDefault());
    }
}