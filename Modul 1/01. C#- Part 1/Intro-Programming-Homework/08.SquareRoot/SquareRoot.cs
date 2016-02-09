using System;

/*Problem 8. Square Root

Create a console application that calculates and prints the square root of the number 12345.
Find in Internet “how to calculate square root in C#”.*/


class SquareRoot
{
    static void Main()
    {
        int number = 12345;
        decimal result = (decimal)Math.Sqrt(number);
        Console.WriteLine(result);
    }
}

