using System;

namespace F_050_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-50. Bekér egy szöveget és betűnként új sorba kiírja. */

            string szovegBetivel;

            Console.WriteLine("Kérek egy szöveget [majd ezt betűnként új sorba kiírom]: ");
            szovegBetivel = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < szovegBetivel.Length; i++)
            {
                Console.WriteLine($"{szovegBetivel[i]}");
            }

            Console.ReadKey();
        }
    }
}
