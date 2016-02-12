using System;

/* Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. */


class DeclareVariables
{
    static void Main()
    {
        int Integer = 4825932;
        byte Byte = 97;
        sbyte Sbyte = -115;
        ushort Ushort = 52130;
        short Short = -10000;

        Console.WriteLine("Integer : {0}", Integer);
        Console.WriteLine("byte : {0}", Byte);
        Console.WriteLine("sbyte : {0}", Sbyte);
        Console.WriteLine("ushort {0}", Ushort);
        Console.WriteLine("short {0}", Short);
    }
}

