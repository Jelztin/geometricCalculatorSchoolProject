using System;

namespace GeometricCalculator
{
    public class Figure
    {

        virtual public string getArea()
        {
            throw new NotSupportedException("invalid type of operation on figure");
        }
        virtual public string getVolume()
        {
            throw new NotSupportedException("invalid type of operation on figure");
        }
        virtual public string getSurfaceArea()
        {
            throw new NotSupportedException("invalid type of operation on figure");
        }
        virtual public string getEdgeLegnth()
        {
            throw new NotSupportedException("invalid type of operation on figure");
        }

    }
}