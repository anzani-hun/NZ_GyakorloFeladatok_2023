using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_021_feladat
{
    internal class Program
    {
        static void Main()
        {
            // 21.	bekér a felhasználótól egy számot, majd kiírja az adott számról, hogy páros, páratlan, vagy nulla.

            int szam;

            Console.Write("Kérek egy számot amit megvizsgálunk, hogy: (páros/páratlan/nulla-e): ");
            szam = Convert.ToInt32(Console.ReadLine());
            

            // ha a szám egyenlő nullával akkor nulla a szám,
            // különben ha a számot elosztjuk kettővel és nulla a maradék akkor páros
            // különben páratlan

            if (szam == 0)
            {
                Console.Write("A megadott szám pontosan nulla");
            }
            else if ( szam % 2 == 0)
           
            {
                Console.Write("A szám páros");
            }
            else
            {
                Console.Write("A szám páratlan");
            }

            Console.ReadKey();
        }
    }
}
