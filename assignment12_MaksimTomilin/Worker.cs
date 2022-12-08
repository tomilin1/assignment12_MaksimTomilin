using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment12_MaksimTomilin
{
    public class Worker
    {
        public Worker(string name, int number)
        {
            WorkerName = name;
            WorkerNumber = number;
        }
        public string WorkerName { get; set; }
        public int WorkerNumber { get; set; }
        public override string ToString()
        {
            return "Worker name: " + WorkerName + "\r\n" + "Worker number: " + WorkerNumber + "\r\n";
        }
    }
}
