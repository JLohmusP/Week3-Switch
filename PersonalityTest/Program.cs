using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Küsi kasutaja lemmikvärv;
            // Kui "punane", kuva "oled romantiline";
            //Kui "sinine", kuva "oled töökas";
            //Kui "roheline", kuva "oled looduse sõber";
            //Kui midagi muud, kuva "oled {userColor} ükssarik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if(userColor == "sinine"){
                Console.WriteLine("Oled töökas.");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva");
        }
    }
}
