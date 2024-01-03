using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_037_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-37. egy tízelemű tömböt feltölt számokkal -50 és +50 között, majd megszámolja a negatív, pozitív és nulla értékeket */

            Random rnd = new Random();
            int[] tomb = new int[10];

            Console.WriteLine("Egy TÍZ elemű tömb feltöltése -50 és 50 közötti véletlen számokkal!\n");
            //tömb feltöltése for ciklussal:
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-50, 51);
                Console.WriteLine(tomb[i]);
            }



            //mibol mennyi lesz megszámlálása.
            //változók nullázása, hogy a számolást onnét kezdje:
            int pozitiv = 0;
            int negativ = 0;
            int nulla = 0;


            Console.WriteLine("\nA kapott számokat megvizsgálva: ");
            //tömb elemeinek az elemzése "+" "-" vagy "0"?
            //ha megegyezik a feltétellel akkor a számlálóját növeljük 1-el.
            for (int i = 0;i < tomb.Length; i++)
            {
                if(tomb[i] > 0)
                {
                    //Console.WriteLine("A szám pozitív");
                    pozitiv++;
                }
                else if (tomb[i] < 0)
                {
                    //Console.WriteLine("A szám negatív");
                    negativ++;
                }
                else
                {
                    //Console.WriteLine("A szám pontosan NULLA");
                    nulla++;
                }
            }


            // A számlálások kiíratása:
            Console.WriteLine($"A pozitív számok darabszáma: {pozitiv}");
            Console.WriteLine($"A negatív számok darabszáma: {negativ}");
            Console.WriteLine($"A nulla számok darabszáma: {nulla}");



            Console.ReadKey();
        }
    }
}
