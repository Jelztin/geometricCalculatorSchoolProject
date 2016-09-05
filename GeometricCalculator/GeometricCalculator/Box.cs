using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    class Box : Figure
    {
        private double v1;
        private double v2;
        private double v3;
        public Box(double v1, double v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string getArea()
        {
            return (v1 * v2).ToString();
        }

        public string getEdgeLegnth()
        {
            return ((v1 + v2 + v3) * 2).ToString();
        }

        public string getSurfaceArea()
        {
            return ((v1 * v2 + v2 * v3 + v1 * v3)*2).ToString();
        }

        public string getVolume()
        {
            throw new NotImplementedException();
        }
    }
}
