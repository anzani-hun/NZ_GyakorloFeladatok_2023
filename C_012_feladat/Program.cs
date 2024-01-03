using System;

namespace C_012_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-12 .  Írjunk programot, amely bekér két egész számot (a,n) a billentyűzetről és kiírja a hatványt ami "a" az "n"-ediken */

            double alap, hatvany, eredmeny;

            Console.Write("Kérem az első egész számot, ami a hatványalap lesz: ");
            alap = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a második egész számot, ami a hatványkitevő lesz: ");
            hatvany = Convert.ToDouble(Console.ReadLine());

            eredmeny = Math.Pow(alap, hatvany);

            Console.WriteLine($"A hatvány: {eredmeny}");

            Console.ReadKey();
        }
    }
}
