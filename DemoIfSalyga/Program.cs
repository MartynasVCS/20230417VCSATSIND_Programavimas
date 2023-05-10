using System;

namespace DemoIfSalyga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Pradžia");
            Console.WriteLine();

            int skaicius = 2;

            if (skaicius > 3)
            {
                Console.WriteLine($"Taip, skaičius {skaicius} yra didesnis už 3");
                Console.WriteLine();
            }

            int amzius = 13;
            
            if (amzius > 25)
            {
                Console.WriteLine("Žmogus jau pilnai suaugęs");
            }
            else if (amzius >= 18)
            {
                Console.WriteLine("Žmogus jau pilnametis");
            }
            else if (amzius >= 12)
            {
                Console.WriteLine("Žmogus yra paauglys");
            }
            else if (amzius > 10)
            {
                Console.WriteLine("Žmogus jau nebe vaikas");
            }
            else if (amzius > 0)
            {
                Console.WriteLine("Žmogus dar vaikas");
            }
            else
            {
                Console.WriteLine("Įvestas netinkamas amžius");
            }
            Console.WriteLine();

            Console.WriteLine("Pabaiga");
        }
    }
}
