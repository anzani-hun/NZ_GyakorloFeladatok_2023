using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_057_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* F-57. Bekér egy szöveget és kiírja úgy, hogy mindegyik szó nagybetűvel kezdődik, kicsivel folytatódik. */

            //a szöveget szavakra kell bontani, és minden szó első betűjét ki kell cserélni .ToUpper segítségével

            string szovegBevitel;
            Console.WriteLine("Kérek egy szöveget!");
            szovegBevitel = Convert.ToString(Console.ReadLine());


            //szöveg szavakra bontása ... egy szavakraBontva tömb elembe eltárolva
            string[] szavakraBontva = szovegBevitel.Split(' ');

            for (int i = 0; i < szavakraBontva.Length; i++)
            {
                //minden szó új sorba
                //Console.WriteLine(szavakraBontva[i]);
                
            }

            

            Console.ReadKey();

        }
    }
}
