using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_017_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* Egy pénztáros a napi bevételének 5%-át megkapja jutalomként. Kérje be a napi bevételt, és írja a képernyőre mennyi a jutalom!
             * A jutalmat kerekítse egész értékre!    */

            // százalék = (5/100​) × 200 = 10    // 200 Ft 5% --> 10 Ft

            double napiBevetel, jutalom;

            Console.Write("Kérem a bolt napi bevételének az összegét: ");
            napiBevetel = Convert.ToDouble(Console.ReadLine());

            jutalom = (napiBevetel / 100) * 5;

            Console.WriteLine($"\nA bolt napi bevétele: {napiBevetel} forint --> a pénztáros napi jutalma: {jutalom} forint.");

            Console.ReadKey();
        }
    }
}
