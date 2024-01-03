using System;

namespace D_035_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-35. Feltölt egy 10 elemű tömböt 1 és 100 közötti egészekkel és kiírja az átlagot meghaladó értékeket */

            Console.WriteLine("A gép feltölt egy tömböt 10 darab véletlen egész számmal!\n");

            Random randomGenerator = new Random();

            int[] tomb = new int[10];


            //a 10elemű tömbünk feltöltése random számokkal 1 és 100 között
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = randomGenerator.Next(1, 101);
                Console.WriteLine($"{tomb[i]}\t");
            }

            //a tíz elemet össze kell adni osszegzéssel  osszead += tomb[i] vagy osszead = osszeAd + tomb[i]
            int atlag;
            int osszead = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                osszead = osszead + tomb[i];
            }

            //az összeg átlagát ki kell számolni
            atlag = (osszead / tomb.Length);

            Console.WriteLine($"\nA 10 elemű tömbünk elemeinek az átlaga: {atlag}");


            Console.WriteLine($"\nAz átlagot meghaladó számok:");
            //az átlag feletti számok kiíratása for ciklussal
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > atlag)
                {
                    Console.WriteLine($"{tomb[i]}");
                }
            }


            Console.ReadKey();
        }
    }
}
