using System;

namespace B_028_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  28.	bekéri a hét napjának számát és kiírja a hét napját szöveggel (1 -> hétfő)  */

            int szam;
            string SzamSzovegge;

            Console.Write("Add meg a hét napjának egy számát (1-7): ");
            szam = Convert.ToInt32(Console.ReadLine());

            // megvizsgáljuk, hogy a bekért szám 1-7 tartományban van-e
            if (szam >= 1 && szam <= 7)
            {
                
                SzamSzovegge = NapSzovegCase(szam);
                Console.WriteLine($"A megadott nap szöveges formára alakítva: { SzamSzovegge }");
            }
            else
            {
                Console.WriteLine("Érvénytelen a megadott szám. Csak 1 és 7 között lehet választani.");
            }

            Console.ReadKey();
        }

        // Bevitt értéknek megfelelően visszaadja a napokat (függvény a nap szöveges nevéhez)
        static public string NapSzovegCase(int atalakit)
        {
            switch (atalakit)
            {
                case 1:
                    return "HÉTFŐ";
                case 2:
                    return "KEDD";
                case 3:
                    return "SZERDA";
                case 4:
                    return "CSÜTÖRTÖK";
                case 5:
                    return "PÉNTEK";
                case 6:
                    return "SZOMBAT";
                case 7:
                    return "VASÁRNAP";
                default:
                    return "Nincs ilyen nap a héten";
            }
        }
    }
}