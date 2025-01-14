using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Calculate
    {
        public double width; public double height;


        public double CalculateArea()
        {
            return width * height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (width + height);
        }

        public double CalculateDiagonal()
        {
            double w = Math.Pow(width, 2);
            double h = Math.Pow(height, 2);
            double c = Math.Sqrt((w + h));
            return c;
        }


    }
}
