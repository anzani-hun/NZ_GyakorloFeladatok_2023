using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H_064_feladat
{
    internal class Program
    {
        static void Main()
        {
            // Szövegfájlok //
            /* H-64. A felhasználótól kapott szöveget kiírja a kaptam.txt fájlba. */

            // using (StreamWriter writer = new StreamWriter("kaptam.txt))
            // using System.IO felvétele felül

            string szovegBevitel;
            Console.WriteLine("Kérek a szöveget, amit majd eltárolunk egy külső [kaptam.txt] fájlban: ");
            szovegBevitel = Console.ReadLine();

            //try-catch használata kell, mert :
            //A try rész tartalmazza a kivételkezeléssel védett utasításokat.
            //Ha a program végrehajtása közben valami hiba lép fel, akkor a try részhez rendelt catch hibakezelőbe akkor kerül a vezérlés
            //ha a catch feltételben meghatározott típusú hiba lép fel.
            try
            {
                // A StreamWriter használatával írunk a fájlba
                using (StreamWriter iras = new StreamWriter("kaptam.txt"))
                {
                    iras.WriteLine(szovegBevitel);
                }

                Console.WriteLine("\nA szöveg sikeresen el lett tárolva a [kaptam.txt] fájlban!");
                Console.WriteLine("\nMinden további új bevitel felülírja az azt megelőző txt tartalmát!");

            }
            catch (FormatException kuld)
            {
                Console.WriteLine($"HIBA: {kuld.Message}");
            }

            Console.ReadKey();
        }
    }
}