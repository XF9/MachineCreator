using System;
using System.IO.Ports;
using MachineCreator.Machines;

namespace MachineCreator
{
    class MachineFactory
    {
        private static MachineFactory _instance;

        private readonly SerialPort _port;
        private readonly Machine _currentMachine;

        private MachineFactory()
        {
            _port = new SerialPort();
            // create Port here

            var enviromentVariable = "A";
            switch (enviromentVariable)
            {
                case "A":
                    _currentMachine = new MachineA(_port);
                    break;
                case "B":
                    _currentMachine = new MachineB(_port);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        ~MachineFactory()
        {
            _port.Close();
        }

        public static Machine GetCurrentMachine()
        {
            if(_instance == null)
                _instance = new MachineFactory();

            return _instance._currentMachine;
        }
    }
}
