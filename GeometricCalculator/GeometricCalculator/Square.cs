using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    class Square : Figure
    {
        double v1;
        double v2;
        public Square(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public override string getArea()
        {
            return (v1 * v2).ToString();
        }

        public override string getEdgeLegnth()
        {
            return (v1 * 2 + v2 * 2).ToString();
        }
    }
}
