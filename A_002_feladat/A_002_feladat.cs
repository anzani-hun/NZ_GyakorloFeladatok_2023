using System;


namespace A_002_feladat
{
    class Program
    {
        static void Main()
        {
            /*2.    bekér két egész számot (𝑎, 𝑏), majd kiszámolja a két szám szorzatát és hányadosát 2 tizedes pontossággal!   */


            double a, b, szorzas, osztas, double_c, osztas_ketjegyu;

            Console.Write("Kérem az első egész számot (a): ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a második egész számot (b): ");
            b = Convert.ToDouble(Console.ReadLine());

            szorzas = a * b;
            osztas = a / b;

            osztas_ketjegyu = Math.Round(osztas, 2);

            Console.WriteLine($"A két szám szorzata: {szorzas}");
            Console.WriteLine($"A két szám hányadosa [2 tizedes pontossággal]: {osztas_ketjegyu}");
            Console.ReadKey(true);
        }
    }
}
