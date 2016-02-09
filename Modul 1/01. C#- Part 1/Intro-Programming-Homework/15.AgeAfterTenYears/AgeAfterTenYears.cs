using System;

/* Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years. */

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Please enter your date of birth  : ");
        string userInput = Console.ReadLine();
        DateTime userBirthday = Convert.ToDateTime(userInput);
        DateTime currentDate = DateTime.Now;
        int currentAge = currentDate.Year - userBirthday.Year;
        int ageAfterTeanYears = currentAge + 10;
        Console.WriteLine("Your current age is {0}", currentAge);
        Console.WriteLine("Your age after 10 years will be : {0}", ageAfterTeanYears);

    }
}

