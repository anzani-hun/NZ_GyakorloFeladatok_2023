using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_014_feladat
{
    internal class Program
    {
        static void Main()
        {

            /*  14.	Bekér egy pénzösszeget és a legkisebb fizetőeszköznek (5 Ft) megfelelőre kerekíti.  */

            int penzosszeg, kerekitettOsszeg;

            Console.WriteLine("Adjon meg egy pénzösszeget és a legkisebb fizetőeszköznek [5 Ft] megfelelőre kerekíti! ");
            penzosszeg = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
