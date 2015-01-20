using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int five = 5;
        int ten = 10;
        Console.WriteLine("five = {0}\nten = {1}\n"
                            , five, ten);
        int x;
        x = five;
        five = ten;
        ten = x;
        Console.WriteLine("five = {0}\nten = {1}\n"
                            , five, ten);

        // using only two variables
        int a = 5;
        int b = 10;
        Console.WriteLine("Initial values a={0} b={1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("Values after exchange a={0} b={1}", a, b);
    }
}