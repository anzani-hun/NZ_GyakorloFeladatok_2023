using System;

namespace C_013_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*C-13. Írassa ki 99-től csökkenő sorrendben az összes pozitív, 3-al osztható pozitív egész számot!*/

            Console.WriteLine("Csökkenő sorrendben az összes szám kiíratása 99 alatt, ami oszható 3-al!\n");

            for (int i = 99; i > 1; i--)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ", ");
                }

            }

            Console.ReadKey();
        }
    }
}
