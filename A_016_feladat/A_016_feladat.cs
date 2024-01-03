using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_016_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  Írjunk programot, amely bekéri „𝐴” és „𝐵” pont koordinátáit, majd kiszámolja azok távolságát.   */
            //Euklideszi távolság kiszámítása - Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            // D = √(b1 − a1 ) ∗ (b1 − a1 ) + (b2 − a2 ) ∗ (b2 − a2 )
            // d = √​(b1−a1)ˇ2+(b2−a2)ˇ2


            double a1, a2, b1, b2, tavolsag;

            // a pontok koordinátáinak értékadása:
            Console.WriteLine("Adja meg az [A] pont koordinátáit: ");
            Console.Write("a1 értéke: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a2 értéke: ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAdja meg az [B] pont koordinátáit: ");
            Console.Write("b1 értéke: ");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2 értéke: ");
            b2 = Convert.ToDouble(Console.ReadLine());

            // a távolság kiszámítása:
            tavolsag = Math.Sqrt(b1 - a1) * (b1 - a1) + (b2 - a2) * (b2 - a2);

            Console.WriteLine($"\nA és B pont közötti egyenes távolsága: {Math.Round(tavolsag, 4)}");
            

            Console.ReadKey();
        }
    }
}
