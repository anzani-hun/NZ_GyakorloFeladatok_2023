using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_020_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-20. Bekér két számot és kiírja a legkisebb közös többszöröst. */

            /* Az a legkisebb pozitív egész szám, ami osztható mindkét bekért számmal.
             * a legkisebb közös többszörös = az adott két szám szorzatát elosztjuk a legnagyobb közös osztójukkal.
             * 
             * pl:  15 és 25 legnagyobb közös osztója 5, ezért (15*25)/5 = 75 lesz az eredmény.
             * 
             */

            Console.WriteLine("Két pozitív egész szám legnagyobb közös osztója és legkisebb közös többszöröse!");

            int szam1, szam2, LKO, LKT;

            Console.Write("Kérem az első számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            LKO = LegnagyobbKozosOszto(szam1, szam2);
            LKT = LegkisebbKozosTobbszoros(szam1, szam2);


            //Legnagyobb közös osztó FÜGGVÉNY KIIRATÁSA:
            Console.WriteLine($"\nA két szám legnagyobb közös osztója: {LKO}");

            //Legkisebb közös többszörös FÜGGVÉNY KIIRATÁSA:
            Console.WriteLine($"A két szám legkisebb közös többszöröse: {LKT}");

            Console.ReadKey();
        }

        static int LegnagyobbKozosOszto(int egyik, int masik)
        {
            int maradek;

            while (masik != 0)
            {
                maradek = egyik % masik;
                egyik = masik;
                masik = maradek;
            }
            return egyik;
        }

        static int LegkisebbKozosTobbszoros(int egyikSzam, int masikSzam)
        {
            return Math.Abs(egyikSzam * masikSzam) / LegnagyobbKozosOszto(egyikSzam, masikSzam);

        }
    }
}
