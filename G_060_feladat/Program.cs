using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_060_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* G-60. Bekér 2 dátumot és kiírja a kettő között eltelt napok számát. */

            string datum1, datum2;

            Console.WriteLine("A helyes dátum megadása [2000-01-01]: ");
            Console.Write("Kérem az első dátumot: ");
            datum1 = Console.ReadLine();
            Console.Write("Kérem a második dátumot: ");
            datum2 = Console.ReadLine();

            //tryparse datum1 és datum2-re
            if ( DateTime.TryParse(datum1, out DateTime datum1ok) &&
                 DateTime.TryParse(datum2, out DateTime datum2ok) )
            {
                TimeSpan elteltNapok = datum2ok - datum1ok;
                int elteltNapokSzama = (int)elteltNapok.TotalDays;

                Console.WriteLine($"\nA két dátum közötti eltelt napok száma: {elteltNapokSzama}");
            }
            else
            {
                Console.WriteLine("Rossz dátumformátumot adtál meg!");
            }

            Console.ReadKey();
        }
    }
}
