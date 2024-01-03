using System;

namespace C_001_feladat
{
    internal class Program
    {
        static void Main()
        {

            /* kiírja 10 és 20 között az egész számokat */


            Console.WriteLine("Kiírja a 10 és a 20 közötti az egész számokat: ");
            for (int i = 10; i < 21; i++)

                Console.WriteLine("" + i);


            Console.WriteLine("\nHa a 10 és a 20 nem tartozik bele, akkor: ");
            for (int j = 11; j < 20; j++)
                {
                    Console.WriteLine("" + j );
                }
            

            Console.ReadKey();
        }
    }
}
