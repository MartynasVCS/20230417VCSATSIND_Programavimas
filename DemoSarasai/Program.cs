using System;
using System.Collections.Generic;

namespace DemoSarasai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode; // išvedime

            // Tuščio sąrašo kūrimas
            List<string> zodziai = new List<string>();

            // Sąrašo iš reikšmių kūrimas
            List<string> uogos = new List<string>() { "braškė", "mėlynė", "vyšnia" };

            // Reikšmių į sąrašą pridėjimas
            zodziai.Add("miestas");
            zodziai.Add("automobilis");

            // Reikšmių perrašymas
            uogos[1] = "vynuogė";
            
            // Reikšmių spausdinimas
            for (int i = 0; i < uogos.Count; i++)
            {
                Console.WriteLine(uogos[i]);
            }
        }
    }
}
