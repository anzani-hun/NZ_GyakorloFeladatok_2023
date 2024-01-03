using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_017_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-17.    Szimuláljon egy felhasználótól bekért számú kockadobást! A gép véletlenszerűen
                        meghatározza a dobás értékét (1 … 6) és kiírja a dobás eredményét. A megfelelő szám elérése
                        után a program készítsen statisztikát a dobások gyakoriságáról! Írjuk ki melyik szám hányszor
                        fordult elő!*/

            Console.WriteLine("Kockadobás szimulálása, megadott dobások száma alapján!");
            
            int i, hanyszorDobjon, kockadobasVeletlen;

            Random randomGenerator = new Random();

            Console.Write("A kockadobások száma?: ");
            hanyszorDobjon = Convert.ToInt32(Console.ReadLine());


            //ezeket ki kell nullázni, hogy innét kezdje a számolásukat statisztika készítésekor.
            int egyesLett = 0, kettesLett = 0, harmasLett = 0, negyesLett = 0, otosLett = 0, hatosLett = 0;

            //for ciklus hogy annyiszor dobjon újra amit megadunk
            for ( i = 0; i < hanyszorDobjon; i++ )
            {
                kockadobasVeletlen = randomGenerator.Next(1, 7);
                Console.WriteLine($"eredmény: " + kockadobasVeletlen);


                //statisztika SWITCH:CASE esetén
                switch (kockadobasVeletlen)
                {
                    case 1 :
                        egyesLett++;
                        break;
                    case 2 :
                        kettesLett++;
                        break;
                    case 3 :
                        harmasLett++;
                        break;
                    case 4 :
                        negyesLett++;
                        break;
                    case 5:
                        otosLett++;
                        break;
                    case 6 :
                        hatosLett++;
                        break;
                }

            }

            // STATISZTIKA KIÍRATÁSA //
            Console.WriteLine("\nKOCKADOBÁSOK STATISZTIKÁJA DOBÁSOK ALAPJÁN: ");
            Console.WriteLine($"{egyesLett} alkalommal lett a kockadobás 1-es");
            Console.WriteLine($"{kettesLett} alkalommal lett a kockadobás 2-es");
            Console.WriteLine($"{harmasLett} alkalommal lett a kockadobás 3-as");
            Console.WriteLine($"{negyesLett} alkalommal lett a kockadobás 4-es");
            Console.WriteLine($"{otosLett} alkalommal lett a kockadobás 5-ös");
            Console.WriteLine($"{hatosLett} alkalommal lett a kockadobás 6-os");

            Console.ReadKey();
        }
    }
}
