using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment12_MaksimTomilin
{
    public class ProductionWorker : Worker
    {
        public ProductionWorker(string name, int number, int shift, decimal hourlyrate) : base (name, number)
        {
            ShiftNumber = shift;
            HourleRate = hourlyrate;
        }
        public int ShiftNumber { get; set; }
        public decimal HourleRate { get; set; }
        public override string ToString()
        {
            return base.ToString() + "Worker shift: " + ShiftNumber + "\r\n" + "Worker hourly pay rate: " + HourleRate + "\r\n";
        }
    }
}
