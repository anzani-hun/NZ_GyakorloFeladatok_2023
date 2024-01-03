using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_019_feladat
{
    class Program
    {
        static void Main()
        {
            /*  Bekéri egy kocka oldalhosszúságát (𝑎) és kiírja a kocka felszínét és térfogatát 2 tizedes pontossággal!  */

            // képlet: 𝐹 = 6 ∗ 𝑎2;  𝑇 = 𝑎3 //


            double a_oldalhosszusag, felszin, terfogat;

            Console.Write("Kérem a kocka oldalhosszúságát (a): ");
            a_oldalhosszusag = Convert.ToDouble(Console.ReadLine());

            felszin = 6 * a_oldalhosszusag * a_oldalhosszusag;
            terfogat = a_oldalhosszusag * a_oldalhosszusag * a_oldalhosszusag;


            Console.WriteLine($"A kocka felszíne: {felszin:F2}");
            Console.WriteLine($"A kocka terfogata: {terfogat:F2}");

            Console.ReadKey(true);
        }
    }
}
