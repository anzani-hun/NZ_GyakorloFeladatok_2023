using System;

namespace A_018_feladat
{
    internal class Program
    {
        static void Main()
        {

            /*  Adott egy derékszögű háromszög a és b befogója. Határozza meg ennek ismeretében az átfogót! */
            // (𝑐 = √𝑎2 + 𝑏2)  avagy A Pitagorasz-tétel képlete:  cˇ2 = aˇ2 + bˇ2

            //A derékszögű háromszög a és b befogójának megadása:
            double a, b, c;

            Console.Write("Kérem a derékszögű háromszög (a) befogóját: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a derékszögű háromszög (b) befogóját: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);

            Console.Write($"\nA derékszögű háromszög átogójának az értéke: {Math.Round(c, 2)}");
            Console.ReadKey();
        }
    }
}
