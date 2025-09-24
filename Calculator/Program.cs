namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Kysytään käyttäjältä lukua 1-4 välillä
        /// </summary>
        /// <returns> palauttaa valinnan </returns>
        static int Valitselaskutoimitus()
        {
            // Tarkistetaan että syöte on 1, 2, 3 tai 4
            int valinta = 0;
            while (true)
            {
                string laskutoimitus = Console.ReadLine();
                if (int.TryParse(laskutoimitus, out valinta) && (valinta >= 1 && valinta <= 4))
                {
                    break;
                }
                // Ilmoitetaan jos syöte on virheellinen
                else
                {
                    Console.WriteLine("Virheellinen syöte. Valitse luku 1-4 väliltä");
                    continue;
                }
            }
            return valinta;
        }

        /// <summary>
        /// Laskee kahden numeron summan
        /// </summary>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns> palauttaa tuloksen </returns>
        static double Yhteenlasku(double Luku1, double Luku2)
        {
            double Tulos = 0;
            Tulos = Luku1 + Luku2;
            return Tulos;
        }

        /// <summary>
        /// Laskee kahden numeron erotuksen
        /// </summary>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns> palauttaa tuloksen </returns>
        static double Vahennyslasku(double Luku1, double Luku2)
        {
            double Tulos = 0;
            Tulos = Luku1 - Luku2;
            return Tulos;
        }
        /// <summary>
        /// Laskee kahden numeron tulon
        /// </summary>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns> palauttaa tuloksen </returns>
        static double Kertolasku(double Luku1, double Luku2)
        {
            double Tulos = 0;
            Tulos = Luku1 * Luku2;
            return Tulos;
        }

        /// <summary>
        /// Laskee kahden numeron osamäärän
        /// </summary>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns> palauttaa tuloksen </returns>
        static double Jakolasku(double Luku1, double Luku2)
        {
            // Tarkistetaan että jakolaskussa ei jaeta nollalla
            if (Luku2 == 0 || Luku1 == 0)
            {
                Console.WriteLine("Nollalla ei voi jakaa.");
                return 0;
            }

            // muuten suoritetaan jakolasku
            double Tulos = 0;
            Tulos = Luku1 / Luku2;
            return Tulos;
        }

        /// <summary>
        /// Kysytään käyttäjältä luku ja varmistetaan että se on kelvollinen
        /// </summary>
        /// <returns> Palautetaan kelvollinen luku </returns>
        static double Kysyluku()
        {
            double Luku = 0;

            while (true)
            {
                string Syöte = Console.ReadLine();
                // Varmistetaan että syöte on kelvollinen
                if (double.TryParse(Syöte, out Luku) && (!string.IsNullOrWhiteSpace(Syöte)))
                {
                    break;
                }
                // Ilmoitetaan jos syöte on virheellinen
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku. Käytä desimaaleissa pilkkua' , ' EI pistettä' . '");
                    continue;
                }
            }
            return Luku;

        }

        /// <summary>
        /// Tulostetaan laskutoimituksen tulos
        /// </summary>
        /// <param name="Tulos"></param>
        static void Tulostatulos(double Tulos)
        {
            Console.WriteLine($"\nTulos = {Tulos}");
        }


        static void Main(string[] args)
        {

            double Tulos = 0;
            int valinta = 0;

            // Kysytään käyttäjältä laskutoimitusta
            Console.WriteLine("Valitse laskutoimitus: \n1. Yhteenlasku\n2. Vähennyslasku\n3. Kertolasku\n4. Jakolasku");
            valinta = Valitselaskutoimitus();

            // Kysytään käyttäjältä kahta lukua
            Console.WriteLine("\nAnna ensimmäinen luku:");
            double Luku1 = Kysyluku();
            Console.WriteLine("\nAnna toinen luku:");
            double Luku2 = Kysyluku();

            // Suoritetaan laskutoimitus valinnan mukaan ja tulostetaan tulos
            switch (valinta)
            {
                case 1:
                    Tulos = Yhteenlasku(Luku1, Luku2);
                    Tulostatulos(Tulos);
                    break;

                case 2:
                    Tulos = Vahennyslasku(Luku1, Luku2);
                    Tulostatulos(Tulos);
                    break;

                case 3:
                    Tulos = Kertolasku(Luku1, Luku2);
                    Tulostatulos(Tulos);
                    break;

                case 4:
                    Tulos = Jakolasku(Luku1, Luku2);
                    Tulostatulos(Tulos);
                    break;
            }
        }
    }
}
