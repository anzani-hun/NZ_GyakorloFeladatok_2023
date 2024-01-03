using System;
using System.Text;

namespace A_008_feladat
{
    class Program
    {
        static void Main()
        {
            /*  bekéri egy négyzet oldalhosszát (𝑎) és kiírja a kerületét és a területét 2 tizedes pontossággal.    */

            /*INFÓ:
                K = 4 * a;
                T = a * a;
             */

            double a_oldalhossz, kerulet, terulet;

            Console.Write("Kérem a négyzet oldalhosszát (a): ");
            a_oldalhossz = Convert.ToDouble(Console.ReadLine());

            kerulet = 4 * a_oldalhossz;
            terulet = a_oldalhossz * a_oldalhossz;

            Console.WriteLine($"A négyzet Kerülete: {Math.Round(kerulet, 2)}");
            Console.WriteLine($"A négyzet Területe: {Math.Round(terulet, 2)}");

            Console.ReadKey(true);
        }
    }
}
