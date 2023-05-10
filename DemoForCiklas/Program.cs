using System;

namespace DemoForCiklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Standartinis for ciklas, vidinis iteratorius vadinamas i, prasideda nuo 0 ir didinamas po vieną
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // vidinis iteratorius nebūtinai turi būti integer
            for (string i = "a"; i != "aaaa"; i += "a")
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Vidinio kintamojo kitimo operacija nebūtinai turi būti aprašyta for sąlygoje
            // Tuomet reikia būti atsargiam, kad nebūtų sukurtas amžinas ciklas
            // Amžino ciklo pavyzdys:
            //for (int i = 0; i <= 5;)
            //{
            //    Console.WriteLine(i);
            //}

            // Vidinio kintamojo keitimas ciklo viduje
            for (int i = 0; i <= 5;)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();

            // Vidinis kintamasis nebūtinai turi kisti vienetu
            for (int i = 0; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
