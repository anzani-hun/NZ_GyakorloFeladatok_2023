using System;

namespace C_003_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C3 - bekér két számot és kiírja kettő közötti páros számokat! */

            int szam1, szam2;

            Console.WriteLine("Bekérünk két számot és kiírja a kettő közötti páros számokat! ");

            Console.Write("\nKérem az első számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a második számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            for (int i = szam1; i <= szam2; i++)
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
