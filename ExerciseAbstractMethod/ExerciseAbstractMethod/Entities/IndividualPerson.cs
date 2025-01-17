using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractMethod.Entities
{
    internal class IndividualPerson : Person
    {

        public double HealthExpenses { get; set; }
        public double MaxPayment = 20000.00;

        public IndividualPerson(string name, double annualPayment, double healthExpenses)
        : base(name, annualPayment)
        {
            HealthExpenses = healthExpenses;
        }
        public override double TotalTax()
        {
            double tax;
            if (AnnualPayment < MaxPayment)
            {
                tax = AnnualPayment * 15 / 100;
            }
            else
            {
                tax = AnnualPayment * 25 / 100;
            }

            if (HealthExpenses > 0.00)
            {
                tax -= (HealthExpenses * 50 / 100);
            }
            return tax;
        }
    }
}
