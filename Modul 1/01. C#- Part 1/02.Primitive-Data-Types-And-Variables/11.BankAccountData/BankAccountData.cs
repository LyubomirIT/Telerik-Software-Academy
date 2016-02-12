using System;

/* Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names. */

class BankAccountData
{
    static void Main()
    {
        Console.Write("Please enter First Name : ");
        string FirstName = Console.ReadLine();
        Console.Write("Please enter Surname : ");
        string Surname = Console.ReadLine();
        Console.Write("Please enter Last Name : ");
        string LastName = Console.ReadLine();

        Console.WriteLine("The names you entered are {0} {1} {2}", FirstName, Surname, LastName);

        Console.Write("Please enter balance : ");
        decimal Balance = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter your bank name : ");
        string BankName = Console.ReadLine();

        Console.Write("Please enter your IBAN : ");
        string IBAN = Console.ReadLine();

        Console.Write("Please enter your first card number : ");
        long Card1 = long.Parse(Console.ReadLine());

        while (Card1 < 0 || Card1 > 10000)
        {
            Console.Write("Please enter your first card number : ");
            Card1 = long.Parse(Console.ReadLine());
        }

        Console.Write("Please enter your second card number : ");
        long Card2 = long.Parse(Console.ReadLine());

        while (Card2 < 0 || Card1 > 10000)
        {
            Console.Write("Please enter your second card number : ");
            Card2 = long.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter your third card number : ");
        long Card3 = long.Parse(Console.ReadLine());

        while (Card2 < 0 || Card1 > 10000)
        {
            Console.Write("Please enter your third card number : ");
            Card3 = long.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("This is your data : ");
        Console.WriteLine();
        Console.WriteLine("Your names are : {0} {1} {2} ", FirstName, Surname, LastName);
        Console.WriteLine("Your balance is : {0}", Balance);
        Console.WriteLine("Your bank name is : {0}", BankName);
        Console.WriteLine("Your IBAN is : {0}", IBAN);
        Console.WriteLine("Your first credit card number is : {0} ", Card1);
        Console.WriteLine("Your second credit card number is : {0} ", Card2);
        Console.WriteLine("Your third credit card number is : {0} ", Card3);


    }
}

