using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsi hinnet;
            //kui "A", kuva "Suurepärane!";
            //Kui "B", kuva "Väga hea!";
            //Kui "C", kuva "Hea!";
            //Kui "D", kuva "Rahuldav.";
            //Kui "E", kuva "Kasin.";
            //Kui "F", kuva "Puudulik.";
            //Kui midagi muud, kuva "Vale väärtus.";


            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B'){
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav.");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin.");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik.");
            }
            else
            {
                Console.WriteLine("Vale väärtus.");
            }
        }
    }
}
