using System;

namespace B_023_feladat
{
    internal class Program
    {
        static void Main()
        {
            // 23. Bekér két számot és a nagyobból kivonja a kisebbet. Az eredményt kiírja a képernyőre.


            Console.WriteLine("Bekérünk két számot és a program a nagyobból kivonja a kisebbet. A cserét elvégzi.");
            int szam1, szam2;
            Console.Write("Kérek egy számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérek egy másik számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());


            Melyiknagyobb(szam1, szam2);
            Console.WriteLine($"A két szám különbsége (a nagyobból kivonja a kisebbet): { Melyiknagyobb( szam1, szam2 ) }");

            Console.ReadKey();

        }


        // ha a szam2 nagyobb, mint a szam1 akkor meg kell cserélni őket, ezzel biztosítva, hogy a nagyobb számból vonjuk ki a kisebb számot //
        public static int Melyiknagyobb(int szam1, int szam2)
        {
            int szamCsere;

            if (szam2 < szam1)
            {
                szamCsere = szam2;
                szam2 = szam1;
                szam1 = szamCsere;

            }

            //visszatérési értéke ha a szam1 nagyobb, mint a szam2 --> szam2 - szam1
             return szam2 - szam1;

        }
        
    }
}

