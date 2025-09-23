using System.Security.Cryptography.X509Certificates;

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
            // Kysytään käyttäjältä Ensimmäistä lukua
            double Luku1 = 0;
            double Luku2 = 0;
             while (true)
            {
                Console.WriteLine("Anna ensimmäinen luku:");
                string Syöte1 = Console.ReadLine();
                // Varmistetaan että syöte on kelvollinen
                if (double.TryParse(Syöte1, out Luku1) && (!string.IsNullOrWhiteSpace(Syöte1)))
                {                     
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku. Käytä desimaaleissa pilkkua , ei pistettä .");
                    continue;
                }
            }
            
             // Kysytään käyttäjältä Toista lukua
            while (true)
            {
                Console.WriteLine("Anna toinen luku:");
                string Syöte2 = Console.ReadLine();
                // Varmistetaan että syöte on kelvollinen
                if (double.TryParse(Syöte2, out Luku2) && (!string.IsNullOrWhiteSpace(Syöte2)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku. Käytä desimaaleissa pilkkua , ei pistettä .");
                    continue;
                }
            }
            // Suoritetaan laskutoimitus valinnan mukaan
            switch (valinta)
            {
                case 1:
                    // Yhteenlasku
                    double Tulos = Luku1 + Luku2;
                    Console.WriteLine($"Tulos = {Tulos}");
                    break;
                case 2:
                    // Vähennyslasku
                    Tulos = Luku1 - Luku2;
                    Console.WriteLine($"Tulos = {Tulos}");
                    break;
                case 3:
                    // Kertolasku
                    Tulos = Luku1 * Luku2;
                    Console.WriteLine($"Tulos = {Tulos}");
                    break;
                case 4:
                    // Jakolasku
                    if (Luku2 == 0 || Luku1 == 0)
                    {
                        Console.WriteLine("Nollalla ei voi jakaa.");
                        break;
                    }
                    Tulos = Luku1 / Luku2;
                    Console.WriteLine($"Tulos = {Tulos}");
                    break;
            }
        }
    }
}
