using System;

namespace C_008_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-8. Számítsa ki az éves középhőmérsékletet miután a felhasználó megadta a havi középhőmérsékleteket.*/

            int honapokSzama = 12; //Januártól-decemberig//

            double[] kozephomersekletHavi = new double[honapokSzama];

            Console.WriteLine("Kérem a havi középhőmérsékleteket: ");

            for (int i = 0; i < honapokSzama; i++)
            {
                Console.Write($"{HonapNeve( i + 1)} hónap: ");
                kozephomersekletHavi[i] = Convert.ToDouble(Console.ReadLine());
            }


            double atlagHomersekletSzamitas = SzamolAtlag(kozephomersekletHavi);

            Console.WriteLine($"\nAz éves középhőmérséklet {Math.Round(atlagHomersekletSzamitas,2)} °C volt, a megadott 12 havi középhőmérséklet alapján.");

            Console.ReadKey();
        }


        //SWITCH-el kötelezően végigmegyünk a hónapokon//
        static string HonapNeve(int honapok)
        {
            switch (honapok)
            {
                case 1 :
                    return "Január";
                case 2 :
                    return "Február";
                case 3 :
                    return "Március";
                case 4:
                    return "Április";
                case 5:
                    return "Május";
                case 6:
                    return "Június";
                case 7:
                    return "Július";
                case 8:
                    return "Augusztus";
                case 9:
                    return "Szeptember";
                case 10:
                    return "Október";
                case 11:
                    return "November";
                case 12:
                    return "December";

                default: return "Nincs ilyen hónap";
            }
        }


        static double SzamolAtlag(double[] tomb)
        {
            double osszeg = 0;
            /// feltöltjük a tömbünket a hónapnak megfelelően a havi középhőmérsékletekkel
            for (int i = 0; i < tomb.Length; i++)
            {
                // összeadjuk a havi középhőmérsékleteket, amíg végig nem érünk rajta.
                osszeg = osszeg + tomb[i];
            }
            /// a havi hőmérsékletet elosztjuk a tömbunk hosszával, ami a hónapok száma.
            return (osszeg / tomb.Length);
        }

    }
}
