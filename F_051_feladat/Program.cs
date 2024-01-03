using System;
using System.Linq;

namespace F_051_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-51. Bekér egy szöveget és fordított sorrendben írja ki a betűit (ablak −> kalba) */

            string adatBevitel;

            Console.WriteLine("Kérek egy szöveget amit visszafelé írok ki utána: ");
            adatBevitel = Convert.ToString(Console.ReadLine());

            // a szöveg elemeinek kiiratása soronként
            /*for (int i = 0; i < adatBevitel.Length; i++)
            {
                Console.Write(adatBevitel[i]);
            }
            */

            Console.WriteLine("\nA bevitt szöveg visszafelé: ");
            // megfordítás for ciklussal..  és -1 mert akkor a tömbön elemein kívűlre mennénk
            for (int i = adatBevitel.Length - 1 ; i >= 0 ; i--)
            {
                //appendel, hozzáadjuk mindig a következő elemet.
                adatBevitel.Append(adatBevitel[i]);
                Console.Write(adatBevitel[i]);
            }

            Console.ReadKey();

        }
    }
}
