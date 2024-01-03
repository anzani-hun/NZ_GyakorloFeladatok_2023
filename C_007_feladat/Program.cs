using System;

namespace C_007_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C7 - Egy bekért számot kiír nullától növekvő, mellette lévő oszlopban nulláig csökkenő sorrendben.*/

            int szam;

            Console.WriteLine("Adj meg egy számot, majd kiírja nullától növekvő, mellette lévő oszlopban nulláig csökkenő sorrendben. ");
            szam = Convert.ToInt32(Console.ReadLine());    


            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            for (int i = szam; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\nvagy egy kiíratással: ");

            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine($"{i}, { szam - i}");
            }

            Console.ReadKey();
        }
    }
}
