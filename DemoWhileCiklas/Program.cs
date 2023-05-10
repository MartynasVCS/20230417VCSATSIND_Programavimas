using System;

namespace DemoWhileCiklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode; // išvedime

            // Dažnai naudojamas while ciklo formatas
            while (true)
            {
                // Veiksmai
                Console.WriteLine("Labas");
                // Veiksmai
                if (true == true) // Kažkokia sąlyga kuri stabdo ciklo darbą
                {
                    break;
                }
            }
            Console.WriteLine();

            // standartinio for ciklo implementacija naudojant while
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();

            // Duomenų įvedimas su duomenų tipo apsauga
            int skaicius = 0;

            while (skaicius == 0)
            {
                try
                {
                    Console.Write("Įveskite sveikąjį skaičių: ");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Įvedėte ne sveikąjį skaičių, bandykite dar kartą.");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            Console.WriteLine($"Įvedėte skaičių {skaicius}");
        }
    }
}
