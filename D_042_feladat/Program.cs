using System;

namespace D_042_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* D-42. Feltölt egy N elemű tömböt 1 és 100 közé eső véletlen számokkal. A tömb méretét a
             *          felhasználó határozza meg! Feltöltés után a tömb elemeit a program írja ki a képernyőre!
                        Másolja át a program egy másik tömbbe a páros számokat!*/

            int n;
            Console.Write("Kérem határozza meg a tömbünk elemeinek a darabszámát! [n]: ");
            n = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] tomb = new int[n]; 

            //for ciklus a tömb feltöltéséhez
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1,101);
                Console.WriteLine(tomb[i]);
            }


            Console.Write("\nA véletlen számok közül ezek a páros számok: ");
            //for ciklus a páros számok megnézéséhez
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    Console.Write($"{tomb[i]}, ");
                }
            }


            //Csak páros számokat tartalmazó új tömb létrehozása:
            int[] tombParosSzamok = new int[tomb.Length];
            int parosak = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if ( tomb[i] % 2 == 0 )
                {
                    tombParosSzamok[parosak] = tomb[i];
                    parosak++;
                }
            }


            Console.WriteLine("\n\nCsak a páros számokat tartalmazó új tömb kiíratása: ");
            // for ciklus a páros számokat tartalmazó tömb bejárásához és kiíratásához:
            for (int i = 0; i < tombParosSzamok.Length; i++)
            {
                Console.Write($"{tombParosSzamok[i]}, ");
            }


            Console.ReadKey();
        }
    }
}
