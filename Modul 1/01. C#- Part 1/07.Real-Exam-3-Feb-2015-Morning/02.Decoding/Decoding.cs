using System;
class Decoding
{
    static void Main()
    {
        double SALT = double.Parse(Console.ReadLine());
        double encodeNumber;

        while (SALT < 1 && SALT > 100)
        {
            SALT = double.Parse(Console.ReadLine());
        }

        string text = Console.ReadLine();

        for (int i = 0; i <= text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            if (char.IsLetter(text[i]))
            {
                encodeNumber = (text[i] * SALT) + 1000;
            }
            else if (char.IsNumber(text[i]))
            {
                encodeNumber = text[i] + SALT + 500;
            }
            else
            {
                encodeNumber = text[i] - SALT;
            }
            if (i % 2 == 0)
            {
                encodeNumber /= 100;
                Console.WriteLine("{0:F2}", encodeNumber);
            }
            else
            {
                encodeNumber *= 100;
                Console.WriteLine(encodeNumber);
            }
        }
    }
}

