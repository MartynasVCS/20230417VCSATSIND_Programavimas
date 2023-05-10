using System;

namespace DemoIvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode; // išvedime
            Console.InputEncoding = System.Text.Encoding.Unicode; // norint įvesti lietuviškus simbolius ir juos paskui išvesti kaip lietuviškus

            Console.Write("Įveskite savo vardą: ");
            string ivedimas = Console.ReadLine();
            Console.WriteLine($"Jūsų vardas: {ivedimas}");
            Console.WriteLine();

            Console.Write("Įveskite savo amžių: ");
            Console.WriteLine($"Jūsų amžius: {Console.ReadLine()}");
            Console.WriteLine();

            Console.Write("Įveskite savo ūgį: ");
            ivedimas = Console.ReadLine();
            double ugis = Convert.ToDouble(ivedimas);
            Console.WriteLine($"Iki 2 metrų jums trūksta {Math.Round(2 - ugis, 2)} metro");
            Console.WriteLine();

            Console.Write("Įveskite savo svorį kilogramais: ");
            double svoris = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Jūsų svoris: {svoris}");
            Console.WriteLine();

            Console.WriteLine("Įveskite kiek turite augintinių: ");
            Console.WriteLine($"Jūs turite {Convert.ToInt32(Console.ReadLine())} augintinių");
            Console.WriteLine();
        }
    }
}
