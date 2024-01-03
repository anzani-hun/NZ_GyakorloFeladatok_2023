using System;

namespace F_053_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-53. Bekér egy szöveget és kiírja ’e’ betűk nélkül. */

            string szovegBevitel, karakterkivagas;

            Console.WriteLine("Kérek egy szöveget, amit 'e' betűk nélkül fogok visszaadni!: ");
            szovegBevitel = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < szovegBevitel.Length; i++)
            {
               // Console.Write(szovegBevitel[i]);
            }


            //a .Replace használata a kis és nagy "e" betű kivágására
            karakterkivagas = szovegBevitel.Replace("e", string.Empty).Replace("E", string.Empty);

            Console.WriteLine("\nA szöveg [e] betűk nélkül: ");
            //Szöveg visszaadása "e" karakter nélkül!
            Console.WriteLine($"{karakterkivagas}");

            Console.ReadKey();
        }
    }
}
