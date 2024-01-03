using System;

namespace C_014_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*C-14. addig kér be egész számokat, amíg nullát nem kap. Ekkor kiírja, hogy „elég” és megáll*/

            int szam;
            Console.Write("Számbekérés addig, amíg nullát nem ütünk, ekkora kiírja: elég\n");

            do
            {
                Console.Write("Kérek egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());

                //ciklusmag: szám kiiraása ha nem nulla.
                if (szam != 0)
                {

                }

             // ciklusfeltétel: addig megy AMÍG a szám nem nulla;
            } while ( szam != 0);

            Console.WriteLine("A megadott számunk NULLA, tehát: Elég! ");


            Console.ReadKey();
        }
    }
}
