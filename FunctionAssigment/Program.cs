using System;

namespace FunctionAssigment
{
    internal class Program
    {
        /// <summary>
        /// Kysyy käyttäjän nimeä
        /// </summary>
        /// <returns>palauttaa nimen,joka ei ole tyhjä</returns>
        static string KysyNimi()
        {
            string name = "";
            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
            return name;
        }

        /// <summary>
        /// Kysytään käyttäjän ikää
        /// </summary>
        /// <returns>
        /// Plauttaa käyttäjän iän positiivisena kokonaislukuna
        /// </returns>
        static int KysyIka()
        {
            int age = 0;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    break;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }
            return age;
        }


        /// </summary> Tulostaa annetun nimen sekä iän </summary>
        static void TulostaNimiJaIka(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// Tarkistaa onko käyttäjä täysi-ikäinen
        /// </summary>
        /// <returns> 
        /// Palauttaa True, jos on täysi-ikäinen, muuten false 
        /// </returns>
        static bool TarkistaTaysiIkainen(int age)
        {
            // Palautetaan vertailun tulos suoraan
            return age >= 18;
        }
        /// <summary>
        /// Vertaa käyttäjän nimeä toiseen nimeen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        static void VertaaNimea(string name, string compareTo)
        {
            string compareName = "Matti";
            // Case-insensitive (suositeltu + StringComparison)
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");
            // Case-sensitive tarkka vertailu
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
        static void Main(string[] args)
        {
            // Selkeämpi koodi
            string name = KysyNimi();
            int age = KysyIka();

            TulostaNimiJaIka(name, age);
            bool isfullAge = TarkistaTaysiIkainen(age);

            if (isfullAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
            
            // Verrataan nimeä merkkijonoon "Matti"
            VertaaNimea(name, "Matti");
        }
    }
}
