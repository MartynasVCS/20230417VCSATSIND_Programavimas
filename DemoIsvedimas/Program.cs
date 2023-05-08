using System;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Labas, pasauli!");
            Console.WriteLine();

            // Reikšmių / kintamųjų išvedimas
            Console.Write("Mano ūgis: ");
            Console.WriteLine(1.91);

            float tecioUgis = 1.81f;
            Console.Write("Mano tėčio ūgis: ");
            Console.WriteLine(tecioUgis);
            Console.WriteLine();

            // Skirtingi kintamųjų + teksto išvedimai
            int amzius = 15;
            float ugis = 1.77f;

            Console.WriteLine("Labas, man yra 15 metų ir mano ūgis yra 1.77 metro");
            Console.WriteLine("Labas, man yra " + amzius + " metų ir mano ūgis yra " + ugis + " metro");
            Console.WriteLine("Labas, man yra {0} metų ir mano ūgis yra {1} metro", amzius, ugis);
            Console.WriteLine($"Labas, man yra {amzius} metų ir mano ūgis yra {ugis} metro");
            Console.WriteLine();
        }
    }
}
