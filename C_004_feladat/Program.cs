using System;

namespace C_004_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C4 - Nem negatív egész számról határozza meg a program, hogy hány jegyű! */

            int szam, szamHossza;

            Console.Write("Kérek egy nem negatív egész számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam >= 0)
            {

                szamHossza = SzamHosszVizsgal(szam);

                Console.WriteLine($"\nA válaszott szám: {szam} [és ez egy {szamHossza}-JEGYŰ szám!]");
            }
            else
            {
                Console.WriteLine("A megadott szám nem pozitív!");
            }

            Console.ReadKey();
        }


        /* függvény ami megszámolja, hogy hány számjegyből áll a szám, úgy hogy ismételten 10-el osztjuk,
         * és addig folytatja, amíg már nem tud osztani 10-el és növeli a hosszt++ */
        static int SzamHosszVizsgal(int szamVizsgal)
        {
            if (szamVizsgal == 0)
            {
                return 1;
            }

            int hossz = 0;

            while (szamVizsgal != 0)
            {
                szamVizsgal /= 10;
                hossz++;
            }

            return hossz;
        }
    }
}
