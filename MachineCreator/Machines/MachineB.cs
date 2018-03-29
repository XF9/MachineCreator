using System;
using System.IO.Ports;

namespace MachineCreator.Machines
{
    class MachineB : Machine
    {
        public MachineB(SerialPort port) : base(port)
        {
        }

        public override void Action1()
        {
            Console.WriteLine("Machine B Action 1");
            Console.WriteLine($"Port open: {Port.IsOpen}");
        }
    }
}
