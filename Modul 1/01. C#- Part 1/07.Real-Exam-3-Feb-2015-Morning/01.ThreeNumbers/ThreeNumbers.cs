using System;
class ThreeNumbers
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        if (A >= B && A >= C)
        {
            Console.WriteLine(A);
        }
        else if (B >= A && B >= C)
        {
            Console.WriteLine(B);
        }
        else if (C >= A && C >= B)
        {
            Console.WriteLine(C);
        }
        if (A <= B && A <= C)
        {
            Console.WriteLine(A);
        }
        else if (B <= A && B <= C)
        {
            Console.WriteLine(B);
        }
        else if (C <= A && C <= B)
        {
            Console.WriteLine(C);
        }

        double arithmeticMean = (A + B + C) / 3;
        Console.WriteLine("{0:F2}", arithmeticMean);
    }
}

