using System;
using System.Text;


namespace NZ_GyakorloFeladatok_2023
{
    internal class Program
    {
        static void Main()
        {
            /*  A-001.	bekér két egész számot (𝑎, 𝑏), majd kiszámolja a két szám összegét, különbségét.    */

            int a, b, osszeadas, kivonas;

            Console.Write("Kérem az első (a) egész számot: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a második (b) egész számot: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            osszeadas = a + b;
            kivonas = a - b;

            Console.WriteLine($"A két szám összege: {osszeadas}");
            Console.WriteLine($"A két szám különbsége: {kivonas}");
            Console.ReadKey(true);

        }
    }
}
