using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randomNummer = generator.Next(1, 100);
            int nummer = 0;
            int f = 0;
            while (nummer != randomNummer)
            {
                Console.WriteLine("Skriv ett tal mellan 1 till 100: ");
                nummer = int.Parse(Console.ReadLine());
                f++;
                if (nummer > randomNummer)
                    Console.WriteLine($"{nummer} är för högt");
                else if (nummer < randomNummer)
                    Console.WriteLine($"{nummer} är för lågt");
                else
                    Console.WriteLine($"Du gissade rätt, talet var {randomNummer}. Det tog {f} försök!");
            }
        }
    }
}
