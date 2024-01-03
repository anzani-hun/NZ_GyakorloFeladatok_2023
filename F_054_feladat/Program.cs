using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace F_054_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-54. Bekér egy szöveget és kiírja, hogy van-e benne névelő (’a’ vagy ’az’) */

            string szovegBevitel;
            Console.WriteLine("Kérek egy szöveget: ");
            szovegBevitel = Convert.ToString(Console.ReadLine());

            //BOOL igaz vagy hamis, tartalmaz-e "a" vagy "az" névlőt a szöveg!
            bool vanBenne_a = szovegBevitel.Contains("a");
            bool vanBenne_az = szovegBevitel.Contains("az");

            if ( vanBenne_a )
            {   //true
                Console.WriteLine("A szöveg tartalmaz [a] névelőt");
            }
            else
            {   //false
                Console.WriteLine("A szöveg nem tartalmaz [a] névelőt");
            }

            if ( vanBenne_az )
            {
                Console.Write("A szöveg tartalmaz [az] névelőt");
            }
            else
            {
                Console.WriteLine("A szöveg nem tartalmaz [az] névelőt]");
            }
            

            Console.ReadKey();
        }
    }
}
