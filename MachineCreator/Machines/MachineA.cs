using System;
using System.IO.Ports;

namespace MachineCreator.Machines
{
    class MachineA : Machine
    {
        public MachineA(SerialPort port) : base(port)
        {
        }

        public override void Action1()
        {
            Console.WriteLine("Machine A Action 1");
            Console.WriteLine($"Port open: {Port.IsOpen}");
        }
    }
}
