using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_015_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*C-15 . Bekér egy számot és kiírja a faktoriálisát
             * avagy a permutációk, lehetőségek száma */

            /*INFÓ:  nem negatív egész szám
             * 6!  = 6*5*4*3*2*1 =  720
             * 7! = 5040
             * 0! = 1
             * 2! = 2
             */

            int szam; //faktorialis//

            Console.Write("Kérek egy nem negatív egész számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            /*
            for (int i = 1; i <= szam; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine($"{szam * i} ");
            }
            */

            if ( szam < 0 )
            {
                Console.WriteLine("NEM lehet negatív szám, ha faktoriálist akarunk számolni!");
            }
            else
            {
                Console.WriteLine($"{szam} fakoriálisa: {Faktorialis(szam)}");
            }

            Console.ReadKey();
        }

        static int Faktorialis(int n)
        {

            // n érték egyenlő-e nullával vagy eggyel. HA IGEN akkor a függvény 1-et ad vissza.
            // mert 0! és 1!-nak az eredménye is 1, többi esetben megyünk az else ágra.
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                // n értéket megszorozzuk faktorialis(n-1)-el, ami azt jelenti, hogy a szám és a szám egyel kisebb
                // faktoriálisának szorzataként kapujk meg.
                return n * Faktorialis(n - 1);
            }
        }
    }
}
