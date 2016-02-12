using System;
/* Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result. */

class NullValuesArithmetic
{
    static void Main()
    {
        int? value1 = 12;
        double? value2 = 20;

        if (value1 == 12)
        {
            value1 = null;
        }

        if (value2 == 20)
        {
            value2 = null;
        }

        Console.WriteLine("Variables with Null values : ");
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        value1 = value1 + 8;
        value2 = value2 + 10.1;
        Console.WriteLine("Variables with new values : ");
        Console.WriteLine(value1);
        Console.WriteLine(value2);
    }
}

