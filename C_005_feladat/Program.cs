using System;

namespace C_005_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C5 - Készítsünk programot, amely 15 darab ’*’-ot ír ki a képernyőre egy sorba!*/

            for (int i = 1; i <= 15; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}
