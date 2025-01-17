using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractMethod.Entities
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public double  AnnualPayment { get; set; }

        protected Person(string name, double annualPayment)
        {
            Name = name;
            AnnualPayment = annualPayment;
        }

        public abstract double TotalTax();


        public override string ToString()
        {
            return $"{Name}: $ {TotalTax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
