using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randomNumber = generator.Next(1, 100);
            int number = 0;
            int i = 0;
            while (number != randomNumber)
            {
                Console.WriteLine("Skriv ett tal mellan 1 till 100: ");
                number = int.Parse(Console.ReadLine());
                i++;
                if (number > randomNumber)
                    Console.WriteLine($"{number} är för högt");
                else if (number < randomNumber)
                    Console.WriteLine($"{number} är för lågt");
                else
                    Console.WriteLine($"Du gissade rätt, talet var {randomNumber}. Det tog {i} försök!");
            }
        }
    }
}