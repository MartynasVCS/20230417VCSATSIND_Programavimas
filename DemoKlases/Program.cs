using System;

namespace DemoKlases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode; // išvedime

            Zmogus zmogusPetras = new Zmogus("Petras", 1.87, 25);
            Zmogus zmogusSaulius = new Zmogus("Saulius", 1.66, 18);
            Zmogus zmogusNiekas = new Zmogus();

            Console.WriteLine(zmogusPetras.vardas);
            Console.WriteLine(zmogusPetras.ugis);
            Console.WriteLine(zmogusPetras.amzius);
            Console.WriteLine();

            Console.WriteLine(zmogusSaulius.vardas);
            Console.WriteLine(zmogusSaulius.ugis);
            Console.WriteLine(zmogusSaulius.amzius);
            Console.WriteLine();

            Console.WriteLine(zmogusNiekas.vardas);
            Console.WriteLine(zmogusNiekas.ugis);
            Console.WriteLine(zmogusNiekas.amzius);
            Console.WriteLine();

            zmogusPetras.Prisistatymas();
            Console.WriteLine();

            zmogusSaulius.Prisistatymas();
            Console.WriteLine();
        }
    }

    internal class Zmogus
    {
        internal string vardas { get; }
        internal double ugis { get; }
        internal int amzius { get; }

        internal Zmogus(string vardas, double ugis, int amzius)
        {
            this.vardas = vardas;
            this.ugis = ugis;
            this.amzius = amzius;
        }

        internal Zmogus()
        {
            
        }

        internal void Prisistatymas()
        {
            Console.WriteLine($"Labas, mano vardas yra {vardas}.");
            Console.WriteLine($"Man yra {amzius} metų ir aš esu {ugis} ūgio.");
        }
    }
}
