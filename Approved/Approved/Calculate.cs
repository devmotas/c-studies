using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approved
{
    internal class Calculate
    {
        public string Name;
        public double A;
        public double B;
        public double C;


        public double CalculateGrade()
        {
            return A + B + C;
        }

        public string IsApprovedPerson()
        {
            return CalculateGrade() >= 60 ? "APROVADO" : "REPROVADO";
        }

        public double CalculateNecessairePoints()
        {
            return 60 - CalculateGrade();
        }

    }
}
