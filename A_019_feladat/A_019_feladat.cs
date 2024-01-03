using System;


namespace A_019_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  Készítsen programot, amely segít a pénztárosnak a papírpénzek értékének megszámolásánál!
             *  Kérje be melyik bankjegyből (500, 1000, 2000, 5000, 10000, 20000) hány darab van,
             *  és a végén adja meg az összes bevételt. */

            // tömb létrehozása a címleteknek:
            int[] bankjegyek = { 500, 1000, 2000, 5000, 10000, 20000 };

            //6 darab papírpénz van
            int[] papirpenzDarabszam = new int[bankjegyek.Length];

            //Összes bevételt 0 értekre kell állítani
            int osszesBevetel = 0;


            //for ciklussal bejárjuk a bankjegyek tömbünknek a hosszát [6 címletet], majd a bankjegyeket összeszorozzuk a darabszámmal és összeadjuk őket.
            int i;

            for (i = 0; i < bankjegyek.Length; i++)
            {
                Console.Write($"Adja meg a(z) {bankjegyek[i]} Ft-os bankjegyek darabszámát: ");
                papirpenzDarabszam[i] = Convert.ToInt32(Console.ReadLine());
                osszesBevetel += bankjegyek[i] * papirpenzDarabszam[i];
            }

            Console.WriteLine($"Az összes bevétel: {osszesBevetel}");

            Console.ReadKey();
        }
    }
}
