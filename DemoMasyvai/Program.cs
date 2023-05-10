using System;

namespace DemoMasyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode; // išvedime

            // Masyvas iš konkrečių reikšmių
            int[] vaikuAmziai = { 7, 8, 12, 5, 9, 3 };

            // Konkretaus dydžio masyvas
            double[] vaikuUgiai = new double[6];

            // Įrašymas į masyvą
            vaikuUgiai[0] = 1.15;
            vaikuUgiai[1] = 1.20;
            vaikuUgiai[2] = 1.65;
            vaikuUgiai[3] = 0.95;
            vaikuUgiai[4] = 1.30;
            vaikuUgiai[5] = 0.52;

            // Masyvo reikšmių nuskaitymas
            Console.WriteLine(vaikuAmziai[0]);
            Console.WriteLine(vaikuUgiai[0]);
            Console.WriteLine();

            // Visų masyvo reikšmių spausdinimas
            for (int i = 0; i < vaikuAmziai.Length; i++)
            {
                Console.WriteLine($"Amžius: {vaikuAmziai[i]}, ūgis: {vaikuUgiai[i]}");
            }
            Console.WriteLine();

            foreach (int amzius in vaikuAmziai)
            {
                Console.WriteLine($"Amžius: {amzius}");
            }
            Console.WriteLine();

            foreach (double ugis in vaikuUgiai)
            {
                Console.WriteLine($"Ūgis: {ugis}");
            }
        }
    }
}
