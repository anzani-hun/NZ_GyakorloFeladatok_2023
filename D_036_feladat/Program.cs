using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace D_036_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-36. Feltölt egy 10 elemű tömböt 100 és 200 közötti egészekkel és kiírja a három legnagyobb értéket */

            Random rnd = new Random();
            int[] tomb = new int[10];

            Console.WriteLine("Tömb feltöltése véletlenszerűen 100 és 200 közötti egész számokkal!\n");
            
            //tömb feltöltése véletlenszerűen 100 és 200 közötti egész számokkal
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(100, 201);
                Console.WriteLine(tomb[i]);  // számok kiíratása
            }



            // A LEGNAGYOBB 3 SZÁM MEGHATÁROZÁSA: 

            //sorrendbe kell rendezni a tömböt
            Array.Sort(tomb);
            
            //csökkenő sorrendbe kell rendezni
            Array.Reverse(tomb);


            Console.WriteLine("\nA három legnagyobb szám: ");
            //for ciklus 3 legnagyobb szám kiíratására
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{tomb[i]} ");
            }

            Console.ReadKey();
        }
    }
}
