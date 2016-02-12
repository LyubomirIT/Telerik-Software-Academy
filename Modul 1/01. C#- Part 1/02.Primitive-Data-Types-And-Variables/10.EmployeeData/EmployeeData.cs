using System;

/* Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console. */


class EmployeeData
{
    static void Main()
    {
        Console.Title = "Employee Data";

        Console.Write("Please enter you first name :");
        string FirstName = Console.ReadLine();

        Console.Write("Please enter your last name :");
        string LastName = Console.ReadLine();

        Console.Write("Please enter your age : ");
        byte age = byte.Parse(Console.ReadLine());
        while (age < 0 || age > 100)
        {
            Console.Write("Please enter an age between 0 and 100 :");
            age = byte.Parse(Console.ReadLine());
        }

        Console.Write("Please enter your gender : ");
        Char gender = char.Parse(Console.ReadLine());

        while (gender != 'm' && gender != 'f')
        {
            Console.Write("Please enter gender : ");
            gender = char.Parse(Console.ReadLine());
        }

        Console.Write("Please enter a Personal ID number : ");
        ulong ID = ulong.Parse(Console.ReadLine());
        while (ID < 1000 || ID > 10000)
        {
            Console.Write("Please enter Personal Id number between 1000 and 10000 : ");
            ID = ulong.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter unique employee number between 27560000 and 27569999 : ");
        long number = long.Parse(Console.ReadLine());

        while (number < 27560000 || number > 27569999)
        {
            Console.Write("Please enter unique employee number between 27560000 and 27569999 : ");
            number = long.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Employee Details : ");

        Console.WriteLine("First name : {0}", FirstName);
        Console.WriteLine("Last name : {0}", LastName);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("ID number : {0}", ID);
        Console.WriteLine("Unique employee number : {0}", number);
    }
}

