using System;

namespace D_038_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* D-038 - Feltölt egy 10 elemű tömböt 200 és 300 közötti egészekkel és kiírja, ezek közöl hányadik a legnagyobb. */

            Random rnd = new Random();
            int[] tomb = new int[10];

            Console.WriteLine("A gép feltölt egy 10 elemű tömböt 200 és 300 közötti véletlen egész számokkal! \nA számaink: ");
            //tömb feltöltése for ciklussal
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(200, 301);
                Console.WriteLine(tomb[i]);
            }

            //a legnagyobb szám megtalálásához meg kell tudni, hányas tomb indexen van a szám.
            int legnagyobbSzam = tomb[0];
            int tombIndexKereses = 0;




            //a tömb elemein végigmegyünk for ciklussal, és ha találunk olyan elemet ami nagyobb mint ez eddigi legnagyobb elem,
            // akkor cseréljük a legnagyobb elemet és annak a tömbben való pozícióját, indexét. 
            
            //HA tomb[i] eleme > mint legnagyobbSzam
            //akkor legnagyobbSzam legyen egyenlő azon tomb[i] értékével
            //a tombIndexKeresest nulla értékkel kezdjük, kiírja a legnagyobb szám tömbben való indexét.
            for (int i = 0; i < tomb.Length; i++)
            {
                if ( tomb[i] > legnagyobbSzam )
                {
                    legnagyobbSzam = tomb[i];
                    tombIndexKereses = i;
                }
            }

            //kapott értékek kiíratása:
            Console.WriteLine($"\nA legnagyobb szám a tömbben: {legnagyobbSzam}");
            Console.WriteLine($"A tömbben tárolt szám a tömb {tombIndexKereses}. indexén van eltárolva.");

            Console.ReadKey();
        }
    }
}
