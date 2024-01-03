using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H_065_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* H-65. A kaptam.txt szövegfájl tartalmát megjeleníti a képernyőn. */
            
            string fajlTartalma;

            //try-catch használata, mert ha a fájl nincs meg pl a program nem fagy ki vagy nem lép ki hibakóddal:
            try
            {
                // egy meglévő fájlból a StreamReader segítségével tudunk beolvasni.
                using (StreamReader olvaso = new StreamReader("kaptam.txt"))
                    
                {
                    fajlTartalma = olvaso.ReadToEnd();
                    Console.WriteLine("A [kaptam.txt] fájl tartalma a következő:\n");
                    Console.Write(fajlTartalma);
                }
            }
            catch (Exception hiba)
            {
                Console.WriteLine($"HIBA! {hiba.Message}");
            }

            Console.ReadKey();
        }
    }
}
