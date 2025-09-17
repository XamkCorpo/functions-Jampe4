namespace FunctionAssigment
{
    internal class Program
    {
        /// <summary>
        /// Kysyy käyttäjältä nimeä
        /// </summary>
        /// <returns>palauttaa ei tyjän nimen</returns>
        static string KysyNimi()
        {
            string name = "";
            bool valid = false;
            // Ask for name and ensure it is not empty
            while (!valid)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    valid = true;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
            return name;
        }
        /// <summary>
        /// Kysyy käyttäjän ikää
        /// </summary>
        /// <returns> palauttaa iän positiivisena kokonaislukuna </returns>
        static int KysyIka()
        {
            int age = 0;
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    valid = true;
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
        /// <returns> Palauttaa True, jos on täysi-ikäinen, muuten false </returns>
        static bool TarkistaTaysiIkainen(int age)
        {
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
            // Comparison ignoring case
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
        static void Main(string[] args)
        {
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
                
            
            // Compare the name to another string (e.g., "Matti")
            VertaaNimea(name, "Matti");
        }
    }
}
