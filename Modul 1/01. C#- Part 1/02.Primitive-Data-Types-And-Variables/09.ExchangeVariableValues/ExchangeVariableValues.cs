using System;

/* Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange. */


class ExchangeVariableValues
{
    static void Main()
    {

        Console.Write("Please enter A : ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Please enter B : ");
        int B = int.Parse(Console.ReadLine());
        int tmp;

        Console.WriteLine("Before Exchange :");
        Console.WriteLine("A = {0}", A);
        Console.WriteLine("B = {0}", B);

        tmp = A;
        A = B;
        B = tmp;

        Console.WriteLine("After Exchange :");
        Console.WriteLine("A = {0}", A);
        Console.WriteLine("B = {0}", B);

    }
}

