using System;

namespace DemoAritmetiniaiVeiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int sudetis = 2 + 3;
            Console.WriteLine(sudetis);
            Console.WriteLine(2 + 3);
            Console.WriteLine();

            Console.WriteLine(5 * 3 + 2);
            Console.WriteLine(2 + 3 * 5);
            Console.WriteLine(5 * (3 + 2));
            Console.WriteLine();

            // Sveikųjų skaičių dalyba
            Console.WriteLine(8 / 4);
            Console.WriteLine(7 / 4);
            Console.WriteLine(7 % 4);
            Console.WriteLine();

            // Realiųjų skaičių dalyba
            Console.WriteLine(7 / 4f);
            Console.WriteLine(7 / 4.0);
            Console.WriteLine(7f / 4);
            Console.WriteLine(7f / 4f);

            // Casting
            int dalinys = 7;
            int daliklis = 4;
            Console.WriteLine(dalinys * 1.0 / daliklis); // primityvus būdas priversti realią dalybą
            Console.WriteLine((double)dalinys / daliklis);
            Console.WriteLine(dalinys / (double)daliklis);

            // Dalyba iš nulio
            Console.WriteLine(1 / 0.0);
        }
    }
}
