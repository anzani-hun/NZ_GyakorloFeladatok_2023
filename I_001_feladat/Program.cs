using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_001_feladat
{
    internal class Program
    {
        static void Main()
        {

            /* I.1 Címletezés
              Bekér egy összeget, majd kiírja, hogy azt hogyan lehet a lehető legkevesebb fizetőeszközből összeállítani. */

            int osszeg;
            Console.WriteLine("Kérek egy egész összeget Forintban és kiírom a lehető legkevesebb címletet felhasználva!");
            osszeg = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nAz összeg a legkevesebb bankjegy felhasználásával így bontható fel: ");
            //Cimletezes függvény meghívása:
            Cimletezes(osszeg);

            Console.ReadKey();
        }

        //cimletezés függvény
        static void Cimletezes(int osszeg)
        {
            
            int[] cimletek = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };

            foreach (int cimlet in cimletek)
            {
                if (osszeg >= cimlet)
                {
                    int darab = osszeg / cimlet;
                    Console.WriteLine($"[{darab}] darab {cimlet} forintos kell");
                    osszeg %= cimlet;
                }
            }
        }
    }
}





