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
            Console.WriteLine();

            // Kintamojo reikšmės perrašymas panaudojant prieš tai buvusią reikšmę
            int skaicius = 11;
            skaicius = skaicius + 5;
            skaicius += 5;
            skaicius -= 5;
            skaicius *= 2;

            // Skaičiaus didinimas / mažinimas vienetu
            skaicius = 10;
            Console.WriteLine(skaicius);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius);
            Console.WriteLine();

            skaicius = 10;
            Console.WriteLine(skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(skaicius);
            Console.WriteLine();

            // Įvairios matematinės operacijos
            Console.WriteLine(Math.Pow(5, 3)); // kėlimas kubu
            Console.WriteLine(Math.Sqrt(9)); // kvadratinė šaknis
            Console.WriteLine(Math.Pow(125, (double)1/3)); // kubinė šaknis (keliam skaičių laipsniu 1/3)
        }
    }
}
