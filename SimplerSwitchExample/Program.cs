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

    public class Light
    {
        bool LightState = false;

        public void PowerOn()
        {
            CheckState(true, "The light is already turned on!", "The light is on");
        }

        public void PowerOff()
        {
            CheckState(false, "The light is already turned off!", "The light is off");
        }

        public void CheckState(bool state, string execption, string notification)
        {
            if (LightState == state)
            {
                Console.WriteLine(execption);
            }
            else
            {
                Console.WriteLine(notification);
                LightState = state;
            }
        }
    }
}
