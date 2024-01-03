using System;

namespace C_021_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-21. Írja ki a képernyőre a 10-es szorzótáblát! */

            Console.WriteLine("Ez egy 10-es szorzótábla!\n");

            // kell egy [i] for ciklus 1-től 10-ig
            for (int i = 1; i < 11; i++)
            {
                //ebben egy [j] for ciklus 1-től 10-ig így lesz 10*10-es szorzótábla
                for(int j = 1; j < 11; j++)
                {
                    Console.Write($"{i * j}\t");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
