using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_012_feladat
{
    class Program
    {
        static void Main()
        {
            /*  Kérje be egy henger sugarát (𝑟) és magasságát (𝑚), majd számítsa ki a henger felszínét (𝐹) és térfogatát (𝑇)! 
             *  Az eredményt írja ki 2 tizedes pontossággal a képernyőre!*/

            // 𝑇 = 𝜋 ∗ 𝑟 ∗ 𝑚
            // 𝐹 = 2 ∗ 𝜋 ∗ 𝑟 ∗ (𝑟 + 𝑚)

            double sugar, magassag, felszin, terfogat;

            Console.Write("Kérem a henger sugarát (r): ");
            sugar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a henger magasságát (m): ");
            magassag = Convert.ToDouble(Console.ReadLine());

            felszin = 2 * Math.PI * sugar * (sugar + magassag);
            terfogat = Math.PI * sugar * magassag;


            Console.WriteLine($"A henger felszíne: F= {felszin:F2} ");
            Console.WriteLine($"A henger terfogata: T= {terfogat:F2} ");
            Console.WriteLine($"A henger terfogata: T= {Math.Round(terfogat, 2)} ");

            Console.ReadKey();
        }
    }
}
