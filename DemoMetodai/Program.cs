using System;

namespace DemoMetodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode; // išvedime

            Pasisveikinimas();
            Console.WriteLine();

            PasisveikinimasSuVardu("Petras");
            PasisveikinimasSuVardu("Martynas");
            PasisveikinimasSuVardu("Antanas");
            Console.WriteLine();

            PrisistatymasSuVarduIrAmziumi("Antanas", 25);
            PrisistatymasSuVarduIrAmziumi("Martynas", 35);
            Console.WriteLine();

            string fraze = PasisveikinimoFraze();
            Console.WriteLine(fraze);
            Console.WriteLine(PasisveikinimoFraze());
            Console.WriteLine(Suma(5, 7));
            Console.WriteLine(Skirtumas(5, 7));
            Console.WriteLine();
        }

        // Metodas be parametru
        static internal void Pasisveikinimas()
        {
            Console.WriteLine("Labas");
            Console.WriteLine("Kaip sekasi?");
            Console.WriteLine("Gerai ar blogai?");
        }

        // Metodas su parametru
        static internal void PasisveikinimasSuVardu(string vardas)
        {
            Console.WriteLine($"Labas, {vardas}!");
        }

        // Metodas su keliais parametras
        static internal void PrisistatymasSuVarduIrAmziumi(string vardas, int amzius)
        {
            Console.WriteLine($"Labas, mano vardas {vardas}, man {amzius} metai/ų");
        }

        // Metodas Grąžinantis reikšmę
        static internal int Suma(int skaicius1, int skaicius2)
        {
            int suma = skaicius1 + skaicius2;
            return suma;
        }

        static internal int Skirtumas(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }

        static internal string PasisveikinimoFraze()
        {
            return "Labas rytas";
        }
    }
}
