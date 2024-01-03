using System;

namespace C_025_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-25. Készítsünk programot, amely az első sorba kiír 15 *-ot, a másodikba 14 *-ot, …, a tizennegyedik
                sorba 2 *-ot, a tizenötödik sorba pedig 1*-ot! A csillagok kiírása a sor elején kezdődjön! */

            //értéket állítunk. Az első sornak 15*ot kell tartalmaznia
            int i, j, elsoSor = 15;

            //for ciklus visszafelé léptetéssel
            for ( i = elsoSor; i >= 1; i-- )
            {
                //újabb for ciklus kell a * kiíratására fordított sorrendben, ezért ez ++. 1.sor->15_csillag, 15.sor->1_csillag
                for ( j = 1; j <= i; j++ )
                {
                    Console.Write("*");
                }

                //minden kirajzolás után új sor legyen.
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
