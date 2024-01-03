using System;

namespace D_043_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* D-43. Feltölt egy N elemű tömböt 1 és 100 közé eső véletlen számokkal. A tömb méretét a
                    felhasználó határozza meg! Feltöltés után a tömb elemeit a program írja ki a képernyőre!
                    Számolja meg a program, hogy hány páros számot tartalmazott a tömb! (megszámlálás tétele)
                    Írja ki a program a páros elemek számát! Írja ki a program a páros elemeket!*/

            int n;
            Console.Write("Kérem határozza meg a tömbünk elemeinek a darabszámát! [n]: ");
            n = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] tomb = new int[n];


            Console.Write($"\n{n} --> darabszámú tömbünk elemei: ");
            //for ciklussal feltöltjűk a tömböt n darabszámnak megfelelően.
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 101);
                Console.Write($"{tomb[i]}" + " ");
            }


            //megszámlálás tételével megszámolni, hogy hány páros számot tartalmazott a generált tömbünk!
            int parosMegszamol = 0;
            int parosSzamok = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0 )
                {
                    parosMegszamol++;   
                }
            }

            Console.WriteLine($"\n\nÖsszesen {parosMegszamol} darab páros számot tartalmaz a tömbünk!");


            //csak a páros számokat listázva:
            Console.WriteLine("\nA páros számok kilistázva: ");
            for (int j = 0; j < tomb.Length; j++)
            {
                if (tomb[j] % 2 == 0 )
                {
                    Console.Write($"{tomb[j]}" + " ");
                }
                
            }

            Console.ReadKey();
        }
    }
}
