using System;

namespace F_052_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-52. Bekér egy szöveget és megszámolja, melyik betűből hány darab van benne. */

            string szovegBevitel;

            Console.WriteLine("Kérek egy szöveget, amiből majd megmondom melyik betűből hány darab van! ");
            szovegBevitel = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < szovegBevitel.Length; i++)
            {
               // Console.WriteLine(szovegBevitel[i]);
            }


            //egy tömbbe betesszük a szöveget és a karaktereit megszámoljuk miből mennyi van
            int[] szamlaloTomb = new int[char.MaxValue + 1]; 

            foreach (char valami in szovegBevitel)
            {
                szamlaloTomb[valami]++;
            }


            // miből mennyi van kiíratása: 
            for (int i = 0; i < szamlaloTomb.Length; i++)
            {
                if (szamlaloTomb[i] > 0) 
                {
                    char valami = (char)i;
                    Console.WriteLine($"[{valami}] karakterből {szamlaloTomb[i]} db van!");
                }
                
            }


            Console.ReadKey();
        }
    }
}
