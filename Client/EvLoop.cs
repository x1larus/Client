using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Client
{
    class EvLoop
    {
        private Queue<Tuple<string, List<string>>> TaskQueue;
        private ManualResetEvent Wait;
        private static object QueueLock;
        public EvLoop()
        {
            TaskQueue = new Queue<Tuple<string, List<string>>>();
            Wait = new ManualResetEvent(false);
            QueueLock = new object();
        }

        public void AddTask(string Cmd, List<string> Args)
        {
            Tuple<string, List<string>> Temp = new Tuple<string, List<string>>(Cmd, Args);
            lock (QueueLock)
            {
                TaskQueue.Enqueue(Temp);
            }
            Wait.Set();
            return;
        }

        private void loop()
        {
            while (true)
            {
                lock (QueueLock)
                {
                    if (TaskQueue.Count != 0)
                        Wait.Set();
                }
                Wait.WaitOne();
                Tuple<string, List<string>> Temp;
                lock (QueueLock)
                {
                    Temp = TaskQueue.Dequeue();
                }
                //parser
                Wait.Reset();
            }
        }
    }
}
