using System;

namespace A_009_feladat
{
    class Program
    {
        static void Main()
        {
            /*  bekéri egy téglalap oldalainak (𝑎, 𝑏) a hosszúságát és kiírja a téglalap kerületét (𝐾) és területét (𝑇) 2 tizedes pontossággal!*/

            /*INFÓ:
             𝐾 = 2 ∗ (𝑎 + 𝑏)
             T = a * b
             */

            double a_oldal, b_oldal, kerulet, terulet;

            Console.Write("Kérem a téglalap (a) oldalának a hosszúságát: ");
            a_oldal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a téglalap (b) oldalának a hosszúságát: ");
            b_oldal = Convert.ToDouble(Console.ReadLine());

            kerulet = 2 * (a_oldal + b_oldal);
            terulet = a_oldal * b_oldal;

            Console.WriteLine();
            Console.WriteLine($"A megadott oldalhosszúságokkal a téglalap kerülete: K = { Math.Round(kerulet, 2) }");
            Console.WriteLine($"A megadott oldalhosszúságokkal a téglalap területe: T = { Math.Round(terulet, 2)}");

            Console.ReadKey();
        }
    }
}
