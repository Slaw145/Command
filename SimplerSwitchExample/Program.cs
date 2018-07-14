using System;

namespace SwtchSimplerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string argument = null;

            Light light = new Light();

            while (!string.IsNullOrEmpty(argument = Console.ReadLine()))
            {
                if (argument == "ON")
                {
                    light.PowerOn();
                }
                else if (argument == "OFF")
                {
                    light.PowerOff();
                }
                else
                {
                    Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
                }
            }

            Console.ReadKey();
        }
    }
}
