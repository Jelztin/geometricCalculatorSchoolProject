using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    class Calculate : CalculationsInterface
    {
        public string calculateResult(Figure figure, OperationType.
            operationType operationType)
        {
            switch ((int)operationType)
            {
                case 1:
                    return figure.getArea();
                case 2:
                    return figure.getEdgeLegnth();
                case 3:
                    return figure.getVolume();
                case 4:
                    return figure.getSurfaceArea();
                default:
                    throw new NotSupportedException("illegal operation type");
            }
        }

    }
}
