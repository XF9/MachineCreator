using System.IO.Ports;

namespace MachineCreator.Machines
{
    public abstract class Machine
    {
        protected readonly Communicator Com;

        protected Machine(Communicator com)
        {
            Com = com;
        }

       public abstract void Action1();
    }
}
