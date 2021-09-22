using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionWorkerManager.Data
{
    public abstract class Employee
    {
        private static int nextNumber = 0;
        private string _name;
        private int _number;

        public virtual string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public virtual int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        public Employee()
        {
            Number = GetNextEmployeeNumber();
            Name = "";
        }

        public static int GetNextEmployeeNumber()
        {
            return ++nextNumber;
        }
    }
}
