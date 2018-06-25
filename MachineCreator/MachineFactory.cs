using System;
using System.IO.Ports;
using MachineCreator.Machines;

namespace MachineCreator
{
    class MachineFactory
    {
        private static MachineFactory _instance;

        private readonly Communicator _com;
        private readonly Machine _currentMachine;

        private MachineFactory()
        {
            _com = new Communicator();

            var enviromentVariable = "A";
            switch (enviromentVariable)
            {
                case "A":
                    _currentMachine = new MachineA(_com);
                    break;
                case "B":
                    _currentMachine = new MachineB(_com);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        public static Machine GetCurrentMachine()
        {
            if(_instance == null)
                _instance = new MachineFactory();

            return _instance._currentMachine;
        }

        public static Communicator GetCurrentMachineCommmunicator()
        {
            if (_instance == null)
                _instance = new MachineFactory();

            return _instance._com;
        }
    }
}
