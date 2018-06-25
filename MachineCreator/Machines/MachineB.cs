using System;
using System.IO.Ports;

namespace MachineCreator.Machines
{
    class MachineB : Machine
    {
        public MachineB(Communicator com) : base(com)
        {
        }

        public override void Action1()
        {
            Com.QueueRequest("CheeseCake", HandleResponseAction1);
        }

        private void HandleResponseAction1(string result)
        {
            Console.WriteLine($"Response for Machine B from Action 1: {result}");
        }
    }
}
