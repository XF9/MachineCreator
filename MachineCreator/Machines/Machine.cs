using System.IO.Ports;

namespace MachineCreator.Machines
{
    public abstract class Machine
    {
        protected readonly SerialPort Port;

        public Machine(SerialPort port)
        {
            Port = port;
        }

       public abstract void Action1();
    }
}
