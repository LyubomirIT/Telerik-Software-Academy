﻿using System;
/* Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

   Examples:

Number a	 Number b	  Equal (with precision eps=0.000001)	          Explanation
5.3	          6.01	                false	                   The difference of 0.71 is too big (> eps)
5.00000001	  5.00000003	         true	                   The difference 0.00000002 < eps
5.00000005	  5.00000001	         true	                   The difference 0.00000004 < eps
-0.0000007	  0.00000007	         true	                   The difference 0.00000077 < eps
-4.999999	  -4.999998	            false	                   Border case. The difference 0.000001 == eps. We consider the numbers are different.
4.999999	  4.999998	            false	                   Border case. The difference 0.000001 == eps. We consider the numbers are different. */

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Please enter A : ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Please enter B : ");
        double B = double.Parse(Console.ReadLine());

        bool areEqual = Math.Abs(A - B) < 0.000001;

        Console.WriteLine("A = B {0} ", areEqual);
    }
}

