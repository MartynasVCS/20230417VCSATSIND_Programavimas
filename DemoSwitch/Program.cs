using System;

namespace DemoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int amzius = 17;

            switch (amzius)
            {
                case 18:
                    Console.WriteLine("Žmogui yra 18 metų");
                    break;
                case 12:
                    Console.WriteLine("Žmogui prasideda paauglystė");
                    break;
                default:
                    Console.WriteLine("Žmogui nei 18 nei 12");
                    break;
            }
        }
    }
}
