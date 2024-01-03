using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_020_feladat
{
    internal class Program
    {
        static void Main()
        {
            // 20.	bekér egy számot és kiírja, hogy páros vagy páratlan.

            int szam;

            Console.WriteLine("Adjon meg egy egész számot, majd kiíratjuk, hogy páros vagy páratlan: ");
            szam = Convert.ToInt32(Console.ReadLine());

            // ha a szám osztható kettővel akkor páros, különben páratlan

            if (szam % 2 == 0)
            {
                Console.Write("A szám páros");
            }
            else
            {
                Console.Write("A szám páratlan");
            }

            Console.ReadKey();
        }
    }
}
