using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_056_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-56. Bekér egy szöveget és a benne lévő szavakat külön sorba írja. */

            string szovegBeker;

            Console.WriteLine("Kérek egy szöveget! Ahol (szóköz) van, ott a következő szót új sorba írom ki!");
            szovegBeker = Convert.ToString(Console.ReadLine());

            //a szöveget szavakra kell bontani a .Split segítségével (' ') -> szóköz
            string[] szavakraBontoTomb = szovegBeker.Split(' ');

            Console.WriteLine("\nA megadott szöveg a tördelés után: ");
            //foreach a bejáráshoz
            foreach (string ezakarmilehet in szavakraBontoTomb)
            {
                Console.WriteLine(ezakarmilehet);
            }

            Console.ReadKey();
        }
    }
}