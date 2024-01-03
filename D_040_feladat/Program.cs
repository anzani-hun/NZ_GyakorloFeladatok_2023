using System;

namespace D_040_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* D-40. Feltölt egy 10 elemű tömböt 1 és 100 közötti egészekkel és kiírja a benne lévő páros és páratlan számok számát! */

            Random rnd = new Random();
            int[] tomb = new int[10];

            Console.WriteLine("A gép feltölt egy tíz számból álló tömböt 1 és 100 közötti egész számokkal! ");

            //tömb feltöltése for ciklussal
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 101);
                Console.WriteLine(tomb[i]);
            }

            //vizsgálandó változók meghatározása, és ennek nullázása.
            int parosMegszamol = 0;
            int paratlanMegszamol = 0;


            //for ciklus a tömb átvizsgálásához:
            for (int i = 0; i < tomb.Length; i++)
            {
                if ( tomb[i] % 2 == 0 )
                {
                    parosMegszamol++;
                }
                else
                {
                    paratlanMegszamol++;
                }
            }

            Console.WriteLine($"\nA tömbben található páros számok száma: {parosMegszamol}");
            Console.WriteLine($"A tömbben található páratlan számok száma: {paratlanMegszamol}");


            Console.ReadKey();
        }
    }
}
