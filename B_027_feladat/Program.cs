using System;

namespace B_027_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  27.	bekéri egy háromszög oldalainak a hosszát és kiírja, hogy szerkeszthető-e.  */

            /*INFÓ: Egy háromszög két oldal hosszának az összege nagyobb, mint a harmadik oldal hossza, akkor szerkeszthető.
             * Azaz: a < b + c és b < a + c  és c < a + b */

            double a, b, c;

            Console.WriteLine("Bekéri a háromszög oldalainak a hosszát (a,b,c) és kiírja, hogy megszerkeszthető-e!");
            Console.Write("\nKérem az első oldal hosszát (a): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a második oldal hosszát (b): ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a harmadik oldal hosszát (c): ");
            c = Convert.ToDouble(Console.ReadLine());

            if ( (a < b + c) && (b < a + c) && (c < a + b) )
            {
                Console.WriteLine("A háromszög szerkeszthető");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető");
            }

            Console.ReadKey();
        }
    }
}
