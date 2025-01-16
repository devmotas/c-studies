using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    internal class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee()
        { }

        public OutsorcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }


        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 110.00 / 100.00);
        }

        public override string ToString()
        {
            return Name + " - $" + Payment().ToString("F2");
        }

    }
}
