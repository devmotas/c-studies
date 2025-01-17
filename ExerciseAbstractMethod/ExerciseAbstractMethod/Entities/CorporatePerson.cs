using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractMethod.Entities
{
    internal class CorporatePerson : Person
    {
        public int Employees { get; set; }


        public CorporatePerson(string name, double annualPayment, int employees)
            : base(name, annualPayment)
        {
            Employees = employees;
        }


        public override double TotalTax()
        {
            double tax;
            if (Employees > 10)
            {
                tax = AnnualPayment * 14 / 100;
            }
            else
            {
                tax = AnnualPayment * 16 / 100;
            }

            return tax;
        }
    }
}
