using System;

namespace C_024_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-24. Bővítse az előző feladatot úgy, hogy a szám eltalálásakor írja ki hány tippelésből sikerült
                        eltalálni a számot!*/

            Random randomGenerator = new Random();
            int veletlenSzam = randomGenerator.Next(1, 101);
            //Console.WriteLine($"Véletlenszám: {veletlenSzam}");//

            int tipp;
            int statisztika = 0;  // kell kezdő értéket megadni

            Console.WriteLine("Ez egy számkitalálós játék, a gép 1 és 100 közötti számot választ, TALÁLD EL!\n");

            do
            {
                Console.Write("Tippeld meg a számot: ");
                tipp = Convert.ToInt32(Console.ReadLine());

                statisztika++;

                if (tipp < veletlenSzam)
                {
                    Console.WriteLine("A keresett szám NAGYOBB");
                }

                else if (tipp > veletlenSzam)
                {
                    Console.WriteLine("A keresett szám KISEBB");
                }

                else
                {
                    Console.WriteLine($"\nSikerült! Kitaláltad a számot! A gépi szám: {veletlenSzam} volt!");
                    Console.Write($"A próbálkozások száma: {statisztika}");
                }
            }
            while (tipp != veletlenSzam);

            Console.ReadKey();
        }
    }
}
