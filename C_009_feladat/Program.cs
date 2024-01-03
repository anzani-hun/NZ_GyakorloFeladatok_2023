using System;

namespace C_009_feladat
{
    internal class Program
    {
        static void Main()
        {
            //C-9. bekér egy számot és kiírja az összes osztóját!

            int szam, i;

            Console.Write("Kérek egy számot, és kiírom az összes osztóját: ");
            szam = Convert.ToInt32(Console.ReadLine());

            //az i nem kezdődhet nulláról, mert nullával nem lehet osztani//
            for (i = 1; i <= szam; i++)
            {
                // ha az osztásnak nincsen maradékja akkor osztható vele és kiíratjuk.
                if (szam % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                
            }

            Console.ReadKey();
        }
    }
}
