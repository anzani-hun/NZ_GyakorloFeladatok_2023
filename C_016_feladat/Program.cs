using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_016_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-16. bekér egy számot és kiírja a megadott szám osztóit, illetve, hogy az adott számnak hány osztója
                     van 1-en és önmagán kívül. */

            // azok a számok kellenek, amelyekkel az adott szám osztható anélkül, hogy maradék lenne, és ezt megszámoljuk darabszam++
            //1-et és önmagát a számot nem kell beleszámolni.//

            int szam;

            Console.Write("Kérek egy számot, és megmondom hány osztója van összesen: ");
            szam = Convert.ToInt32(Console.ReadLine());

            // egy darabszam értéket nullára állítunk, hogy innét kezdje a számolást.
            int i, darabszam = 0;

            Console.Write("\nA szám osztói kilistázva: \n");
            //for ciklussal kettőről indulva 
            for ( i = 2; i <= szam / 2 ; i++ )
            {
             if (szam % i == 0)
                {
                    Console.WriteLine(i);
                    darabszam++;
                }
            }

            Console.WriteLine($"\n{szam} számnak összesen {darabszam + 2} darab osztója van [1-et és önmagát is beleszámolva]\n");
            Console.WriteLine($"{szam} számnak {darabszam} darab osztója van");
            

            Console.ReadKey();
        }
    }
}
