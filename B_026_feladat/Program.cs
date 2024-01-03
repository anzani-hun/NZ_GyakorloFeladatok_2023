using System;

namespace B_026_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  26.	bekér a felhasználótól két számot. A program döntse el, hogy az elsőként bekért számnak osztója-e a másodikként bekért szám.
             *  Írja ki az osztás eredményét is. */

            double szam1, szam2, osztasEredmenye;

            Console.WriteLine("Az elsőként bekért számnak osztója-e a másodikként bekért szám?");
            Console.Write("Kérem az első számot: ");
            szam1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            szam2 = Convert.ToDouble(Console.ReadLine());

            osztasEredmenye = szam1 / szam2;

            if ( szam2 == 0 )
            {
                Console.Write($"Mivel a második megadott szám = {szam2} --> Nullával nem lehet osztani.");
            }
            else if ( szam1 % szam2 == 0 )
            {
                Console.Write($"A [{szam1}] osztója [{szam2}]-nak, és az osztás eredménye: {osztasEredmenye}");
            }
            else
            {
                Console.WriteLine($"[{szam1}] nem osztója [{szam2}]-nek");
            }
            Console.ReadKey();
        }
    }
}
