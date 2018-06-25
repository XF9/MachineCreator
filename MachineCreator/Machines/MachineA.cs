using System;

namespace MachineCreator.Machines
{
    class MachineA : Machine
    {
        public MachineA(Communicator com) : base(com)
        {
        }

        public override void Action1()
        {
            Com.QueueRequest("Sample Request", HandleResponseAction1);
        }

        private void HandleResponseAction1(string result)
        {
            Console.WriteLine($"Response for Machine A from Action 1: {result}");
        }
    }
}
