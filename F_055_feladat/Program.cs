using System;
using System.Linq;

namespace F_055_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-55. Bekér egy szöveget és csak a benne lévő magánhangzókat írja ki. */
            //osszes maganhangzo: aáeéuúiíoóüűöőAÁEÉUÚIÍOÓÜŰÖŐ
            //using System.Linq... kellett a lenti függvény futásához.

            string szovegBevitel;

            Console.WriteLine("Kérek egy szöveget, és csak a benne lévő magánhanzókat írom ki!");
            szovegBevitel = Convert.ToString(Console.ReadLine());


            //A szövegben lévő magánhangzók kiíratása a lenti Maganhangzo ellenőrző függvény segítségével.
            Console.WriteLine("\nA megadott szöveg összes magánhangzói: ");

            foreach (var betukkkk in szovegBevitel)
            {
                if ( Maganhangzo(betukkkk))
                {
                    Console.Write(betukkkk);
                }
            }

            Console.ReadKey();
        }

        // bool függvény, hogy megnézzük magánhangzó-e a karakterünk
        static bool Maganhangzo(char betu)
        {
            return "aáeéuúiíoóüűöőAÁEÉUÚIÍOÓÜŰÖŐ".Contains(betu);
        }
    }
}
