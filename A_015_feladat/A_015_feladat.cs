using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_015_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  15.	Írjon programot, mely beolvas egy számpárt a billentyűzetről, majd kiírja a két szám számtani közepét!  */

            //  Két nemnegatív szám számtani közepének a két szám összegének a felét nevezzük.

            double szamEgy, szamKetto, szamtaniKozep;

            Console.Write("Kérem az első számot: ");
            szamEgy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem az első számot: ");
            szamKetto = Convert.ToDouble(Console.ReadLine());

            szamtaniKozep = (szamEgy + szamKetto) / 2;

            Console.WriteLine();
            Console.WriteLine($"A két szám: {szamEgy} és {szamKetto} --> mértani közepe: {szamtaniKozep}");

            Console.ReadKey();
        }
    }
}
