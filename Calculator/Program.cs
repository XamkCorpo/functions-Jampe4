namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Kysytään käyttäjältä laskutoimitusta
            Console.WriteLine("Valitse laskutoimitus: \n1. Yhteenlasku\n2. Vähennyslasku\n3. Kertolasku\n4. Jakolasku");

            // Tarkistetaan että syöte on 1, 2, 3 tai 4
            
            int valinta = 0;
            while(true)
            {
                string laskutoimitus = Console.ReadLine();
                if (int.TryParse(laskutoimitus, out valinta) && (valinta >= 1 && valinta <= 4))
                {
                    break;
                }
                
                else
                {
                    Console.WriteLine("Virheellinen syöte. Valitse luku 1-4 väliltä");
                    continue;
                }

            }
            // Kysytään käyttäjältä kahta lukua
            int Luku1 = 0;
            int Luku2 = 0;
             while (true)
            {
                Console.WriteLine("Anna ensimmäinen luku:");
                string Syöte1 = Console.ReadLine();
                
                Console.WriteLine("Anna toinen luku:");
                string Syöte2 = Console.ReadLine();

                
            }
            
        }
    }
}
