using System;

namespace B_034_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  A program bekéri egy tetszőleges pont koordinátáit és kiírja melyik síknegyedben van! */

            /*INFÓ:
                    + és + → Első síknegyed
                    - és + → Második síknegyed
                    - és - → Harmadik síknegyed
                    + és - → Negyedik síknegyed
             */

            int x, y;

            Console.WriteLine("Adj meg két egész számot, amik egy pont koordinátái lesznek: ");
            Console.Write("Kérem a pont első koordinátáját (X): ");
            x = Convert.ToInt32(Console.ReadLine());


            Console.Write("Kérem a pont második koordinátáját (Y): ");
            y = Convert.ToInt32(Console.ReadLine());


            if (x == 0 && y == 0)
            {
                Console.WriteLine($"A megadott pont az ORIGÓban van, mivel a két megadott szám {x} , {y}");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("A pont koordinátái az első síknegyedben vannak!");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("A pont koordinátái a második síknegyedben vannak!");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("A pont koordinátái a harmadik síknegyedben vannak!");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("A pont koordinátái a negyedik síknegyedben vannak!");
            }

            Console.ReadKey();

        }
    }
}
