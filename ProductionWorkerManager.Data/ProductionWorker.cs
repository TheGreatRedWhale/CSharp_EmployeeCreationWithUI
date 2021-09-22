using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionWorkerManager.Data
{

    public class ProductionWorker : Employee
    {
        private double minimumWage = 14.00;
        public enum Shift
        {
            Unassigned = 0,
            Day = 1,
            Night = 2
        }
        public Shift ShiftNumber { get; set; }
        public double HourlyRate { get; set; }

        public ProductionWorker()
        {
            ShiftNumber = Shift.Unassigned;
            HourlyRate = minimumWage;
        }
    }
}
