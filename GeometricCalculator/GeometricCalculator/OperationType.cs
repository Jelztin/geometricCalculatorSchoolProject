using System;

namespace GeometricCalculator
{
    public class OperationType
    {
        public enum operationType{ area = 1, edge = 2, volume = 3, surface = 4 }
        
        public static operationType getOperationType(string text)
        {
            switch (text)
            {
                case "Area":
                    return operationType.area;
                case "Edge Length":
                    return operationType.edge;
                case "Volume":
                    return operationType.volume;
                case "Surface Area":
                    return operationType.surface;
                default:
                    throw new NotSupportedException("illegal operation");
            }
        }
    }
}