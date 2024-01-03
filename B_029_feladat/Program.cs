using System;

namespace B_029_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*  29.	bekéri a hónap számát és kiírja szövegesen (6 -> június)    */

            int bekertAdat;
            string vegeredmeny;

            Console.Write("Adjál meg egy hónap számot: [1-12]: ");
            bekertAdat = Convert.ToInt32(Console.ReadLine());

            vegeredmeny = Honapok(bekertAdat);


            if (bekertAdat >= 1 && bekertAdat <= 12)
            {
                Console.WriteLine($"A kiválasztott hónap száma: { bekertAdat }! Ez szövegesen kiírva: { vegeredmeny }");
            }
            else
            {
                Console.WriteLine("Nem megfelelő hónapszámot adtál meg!");
            }

            Console.ReadKey();
        }


        static public string Honapok(int konvertal)
        {
            switch (konvertal)
            { 
                case 1:
                    return "JANUÁR";
                case 2:
                    return "FEBRUÁR";
                case 3:
                    return "MÁRCIUS";
                case 4:
                    return "ÁPRILIS";
                case 5:
                    return "MÁJUS";
                case 6:
                    return "JÚNIUS";
                case 7:
                    return "JÚLIUS";
                case 8:
                    return "AUGUSZTUS";
                case 9:
                    return "SZEPTEMBER";
                case 10:
                    return "OKTÓBER";
                case 11:
                    return "NOVEMBER";
                case 12:
                    return "DECEMBER";
                default:
                    return "NINCS ILYEN HÓNAP";
            }
        }
    }
}
