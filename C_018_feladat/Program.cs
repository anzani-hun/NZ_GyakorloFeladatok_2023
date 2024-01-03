using System;

namespace C_018_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-18. bekér egy számot és kiírja, hogy prím-e.
             * Egy szám akkor prímszám, ha 2 osztója van, 1 és maga a szám */

            int i, adatBevitel;

            Console.Write("Kérek egy pozitív egész számot, és megmondom PRÍMSZÁM-e: ");
            adatBevitel = Convert.ToInt32(Console.ReadLine());

            // alap esetben az érték true.
            bool isPrimszam = true;


            if ( adatBevitel < 2 )
            {
                isPrimszam = false;
            }
            else
            {
                // ha a ciklus végéig nem találunk osztót, akkor prímszám
                for ( i = 2; i < adatBevitel; i++ )
                {
                    if ( adatBevitel % i == 0)
                    {
                        isPrimszam = false;
                        break;
                    }
                }
            }


            // PRÍM vagy SEM kiíratás
            if ( isPrimszam )
            {
                Console.WriteLine($"{adatBevitel} --> prímszám, mert csak két osztója van [1 és önmaga]");
            }
            else
            {
                Console.WriteLine($"{adatBevitel} --> NEM prímszám");
            }

            Console.ReadKey();

        }
    }
}
