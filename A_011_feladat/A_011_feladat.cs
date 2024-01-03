using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_011_feladat
{
    class Program
    {
        static void Main()
        {
            /*  Bekéri egy téglatest oldalainak a hosszát (𝑎, 𝑏, 𝑐) és kiírja a téglatest felszínét (𝐹) és térfogatát (𝑇) 3 tizedes pontossággal.   */

            //felszin: 𝐹 = 2 ∗ 𝑎 ∗ 𝑏 + 2 ∗ 𝑎 ∗ 𝑐 + 2 ∗ 𝑏 ∗ 𝑐
            //terfogat: 𝑇 = 𝑎 ∗ 𝑏 ∗ 𝑐 


            double a_oldal, b_oldal, c_oldal, felszin, terfogat;

            Console.Write("Kérem a téglatest (a) oldalának hosszát: ");
            a_oldal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a téglatest (b) oldalának hosszát: ");
            b_oldal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a téglatest (c) oldalának hosszát: ");
            c_oldal = Convert.ToDouble(Console.ReadLine());


            felszin = (2 * a_oldal * b_oldal) + (2 * a_oldal * c_oldal) + (2 * b_oldal * c_oldal);
            terfogat = (a_oldal * b_oldal * c_oldal);

            Console.WriteLine($"A téglatest felszíne: F: {felszin:F2}");
            Console.WriteLine($"A téglatest térfogata: T: {terfogat:F2}");

            Console.ReadKey();
        }
    }
}
