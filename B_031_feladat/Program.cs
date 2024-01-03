using System;


namespace B_031_feladat
{
    internal class Program
    {
        static void Main()
        {

            /* Bekéri a focicsapat által a fordulóban szerzett pontok számát és kiírja, mit játszott a csapat.
             * (0 -> vereség, 1 -> döntetlen, 3 -> győzelem) */

            int szerzettPontok;
            string kiiratas;

            Console.Write("Add meg a focicsapat által szerzett pontot: ");
            szerzettPontok = Convert.ToInt32(Console.ReadLine());


            kiiratas = Eredmeny(szerzettPontok);

            if (szerzettPontok >= 0 && szerzettPontok <= 3)
            {
                Console.WriteLine($"{kiiratas}");
            }
            else
            {
                Console.WriteLine("NINCS ilyen PONT lehetőség");
            }
            
            

          /*  if (szerzettPontok == 0)
            {
                Console.WriteLine("A csapat kikapott");
            }
            else if (szerzettPontok == 1)
            {
                Console.WriteLine("Döntetlen");
            }
            else
            {
                Console.WriteLine("Győzelem");
            }  
          */

       
            Console.ReadKey();
        }

        static public string Eredmeny(int konvertal)
        {
            switch (konvertal)
            {
                case 0:
                    return "VERESÉG";
                case 1:
                    return "DÖNTETLEN";
                case 3:
                    return "GYŐZELEM";
                default:
                    return "NINCS ILYEN SZERZETT PONT LEHETŐSÉG!";
            }
        }
    }
}
