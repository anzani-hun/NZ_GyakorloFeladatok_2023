using System;

namespace D_039_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* D-39. Feltölt egy 10 elemű tömböt 20 és 60 közötti egészekkel és kiírja,
             * ezek közöl hányadik a legnagyobb és a legkisebb és mi az értékük */

            Random rnd = new Random();
            int[] tomb = new int[10];

            Console.WriteLine("A gép feltölt egy 10 elemű tömböt egész számokkal 20 és 60 között!");

            //tömb feltöltése for ciklussal
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(20, 61);
                Console.WriteLine($"A tömb indexe: {i} --> {tomb[i]}");
            }


            // a vizsgálandó változók rögzítése, és honnét kezdje a számolást.
            int legnagyobbSzam = tomb[0];
            int legkisebbSzam = tomb[0];
            int indexLegnagyobb = 0;
            int indexLegkisebb = 0;


            //for ciklus a tömb bejárásához, amiben a legnagyobb számot megkeressük
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > legnagyobbSzam)
                {
                    legnagyobbSzam = tomb[i];
                    indexLegnagyobb = i;
                }
            }

            //for ciklus a tömb bejárásához, amiben a legkisebb számot megkeressük
            for (int i = 0;i < tomb.Length; i++)
            {
                if ( tomb[i] < legkisebbSzam )
                {
                    legkisebbSzam = tomb[i];
                    indexLegkisebb = i;
                }
            }

            Console.WriteLine($"\nA legkisebb számunk: {legkisebbSzam}, és a tömbünk {indexLegkisebb}. helyén található!");
            Console.WriteLine($"A legnagyobb számunk: {legnagyobbSzam}, és a tömbünk {indexLegnagyobb}. helyén található!");

            Console.ReadKey();
        }
    }
}
