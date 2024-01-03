using System;
using System.Runtime.InteropServices;

namespace C_006_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-6. Írassa ki a számokat 1-től 20-ig és mellé a négyzetüket is!*/

            Console.WriteLine("Írassa ki a számokat 1-től 20-ig és mellé a négyzetüket is!");

            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i );
                Console.WriteLine(" négyzete: " + i * i);
            }

            Console.ReadKey();
        }
    }
}
