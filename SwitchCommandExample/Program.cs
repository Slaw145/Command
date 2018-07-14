using System;

namespace SwichCommandExample
{
    class Program
    {
        public static void Main(string[] arguments)
        {
            string argument=null;

            ISwitchable lamp = new Light();

            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            Switch @switch = new Switch(switchClose, switchOpen);

            while(!string.IsNullOrEmpty(argument =Console.ReadLine()))
            {
                if (argument == "ON")
                {
                    @switch.Open();
                }
                else if (argument == "OFF")
                {
                    @switch.Close();
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
