using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    public interface CalculationsInterface
    {
        
        string calculateResult(Figure figure, OperationType.operationType operationType);
    }
}
