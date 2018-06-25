using System;
using System.Collections.Generic;
using System.Linq;

namespace MachineCreator
{
    public class Communicator
    {
        private readonly List<QueueEntry> _queue;

        public Communicator()
        {
            _queue = new List<QueueEntry>();
        }

        public void QueueRequest(string command, Action<string> onResponse)
        {
            _queue.Add(new QueueEntry
            {
                Command = command,
                OnResponse = onResponse
            });
        }

        public void ExecuteFirstCommand()
        {
            if (_queue.Any())
            {
                var entry = _queue.First();
                _queue.RemoveAt(0);

                var result = new string(entry.Command.Reverse().ToArray());
                entry.OnResponse(result);
            }
        }

        private class QueueEntry
        {
            public string Command { get; set; }
            public Action<string> OnResponse { get; set; }
        }
    }
}
