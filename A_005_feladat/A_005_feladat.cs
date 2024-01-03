using System;
using System.Text;


namespace A_005_feladat
{
    class Program
    {
        static void Main()
        {

            /*  bekéri egy kör sugarát és kiírja a kerületét és a területét 4 tizedes pontossággal.   */

            /*INFÓK:
             𝐾 = 2 ∗ 𝑟 ∗ 𝜋 
             𝑇 = 𝑟2 ∗ 𝜋 
            */

            double r_sugar, kerulet, terulet, pi_erteke, kerekitve_k, kerekitve_t;

            Console.Write("Kérem a kör sugarát (r): ");
            r_sugar = Convert.ToDouble(Console.ReadLine());

            pi_erteke = Math.PI;
            kerulet = (2 * r_sugar * pi_erteke);
            terulet = (r_sugar * r_sugar * pi_erteke);

            kerekitve_k = Math.Round(kerulet, 4);
            kerekitve_t = Math.Round(terulet, 4);

            Console.WriteLine();
            Console.WriteLine("A kapott értékeink 4 tizedes pontosságra lesznek kerekítve!");
            Console.WriteLine($"A megadott értékkel a körünk kerülete: K: {kerekitve_k}");
            Console.WriteLine($"A megadott értékkel a körünk területe: T: {kerekitve_t}");


            Console.ReadKey(true);

        }
    }
}

