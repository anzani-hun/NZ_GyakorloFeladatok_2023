using System;

namespace C_002_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* kiírja 10 és 30 között a páros számokat */

            Console.WriteLine("Kiíratjuk a 10 és a 30 közötti páros számokat: ");

            int i = 0;

            for (i = 10; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
