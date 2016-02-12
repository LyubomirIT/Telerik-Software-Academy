using System;

/* Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost. */


class FloatOrDouble
{
    static void Main()
    {
        double number1 = 34.567839023;
        double number2 = 8923.1234857;
        float number3 = 12.345f;
        float number4 = 3456.091f;

        Console.WriteLine("Variables of type double : {0}, {1}", number1, number2);
        Console.WriteLine("Variables of type float :{0}, {1}", number3, number4);
    }

}

