using System;

namespace MachineCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = MachineFactory.GetCurrentMachine();

            machine.Action1();
            MachineFactory.GetCurrentMachineCommmunicator().ExecuteFirstCommand();

            Console.ReadLine();
        }
    }
}
