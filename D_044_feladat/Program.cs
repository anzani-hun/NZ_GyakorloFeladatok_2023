using System;

namespace D_044_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* D-44. Generáljon ötös lottószám tippeket! Biztosítsa, hogy nem lehet 2 azonos szám a kihúzottak között! */
            //A lottószámok 1 és 90 közötti egész számok lehetnek
            // és növekvő sorba is rendezni

            Console.WriteLine("Az 5-ös lottó számok kihúzásának a szimulálása! [NEM lehet számismétlés] \n");

            Random rnd = new Random();
            
            //5 elemből álló tömb kell az ötöslottó számok eltárolására
            int[] lottoHuzas = new int[5];


            //for ciklus a tömb feltöltéséhez
            //hogy ne legyen duplikáció, ezért DuplikacioVan függvény meghívása
            

            for (int i = 0; i < lottoHuzas.Length; i++)
            {
                int huzottSzam;

                do
                {
                    huzottSzam = rnd.Next(1, 91);
                }
                while ( DuplikacioVan(lottoHuzas, huzottSzam) );

                lottoHuzas[i] = huzottSzam;

                Console.WriteLine($"A kihúzott { i + 1 }. szám: { huzottSzam }");
            }


            // a lottószámok sorba rendezése:
            Console.WriteLine("\nA kihúzott számok növekvő sorba rendezve: ");
            Array.Sort(lottoHuzas);

            for (int i = 0; i < lottoHuzas.Length; i++)
            {
                Console.Write($"{lottoHuzas[i] + " "}");
            }
            


            Console.ReadKey();
        }


        //a duplikáció elkerülése miatt megnézzük, hogy a kihúzott szám már szerepel-e a tömbünkben, ha igen akkor új számot visz be
        static bool DuplikacioVan(int[] lottoHuzas, int vizsgal)
        {
            for ( int i = 0; i < lottoHuzas.Length; i++ )
            {
                if (lottoHuzas[i] == vizsgal)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
