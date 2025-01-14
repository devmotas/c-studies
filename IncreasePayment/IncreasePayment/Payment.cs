using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasePayment
{
    internal class Payment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
