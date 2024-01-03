using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_061_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* G-061. Bekér egy dátumot és a négy héttel későbbi dátumot írja ki. */

            string datumBekeres;
            Console.Write("Kérek egy dátumot: ");
            datumBekeres = Console.ReadLine();

            if (DateTime.TryParse(datumBekeres, out DateTime datumBekeresOK))
            {
                DateTime pluszNegyHet = datumBekeresOK.AddDays( 4 * 7 );  //4x egy hét
                Console.WriteLine($"\nA négy héttel későbbi dátum: {pluszNegyHet}");
            }
            else
            {
                Console.WriteLine("Rossz dátumformátumot adtál meg! Egy jó formátum: 2000.01.01");
            }

            Console.ReadKey();
        }
    }
}
