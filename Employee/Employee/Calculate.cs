using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Calculate
    {
        public string Name;
        public double GrossSalary;
        private double NetSalary;
        public double Tax;

        public override string ToString()
        {
            return $"{Name}, $ {CalculateNetPayment():F2}";
        }

        public double CalculateNetPayment()
        {
            NetSalary = GrossSalary - Tax;
            return NetSalary;
        }

        public void IncreasePayment(double amount) {
        GrossSalary += GrossSalary * (amount / 100) ;
        }
    }
}
