using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    internal class Triangle : Polygon, IPlaneShape
    {
        private float sideA;
        private float sideB;
        private float sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            number_of_sides = 3;
        }

        public Triangle(float sideLength)
        {
            sideA = sideB = sideC = sideLength;
            number_of_sides = 3;
        }

        public double GetArea()
        {
            return 0.25 * Math.Sqrt( (sideA + sideB + sideC) * 
                                     (sideB + sideC - sideA) * 
                                     (sideA - sideB + sideC) * 
                                     (sideA + sideB - sideC) );
        }

        public double GetCircumference()
        {
            return sideA + sideB + sideC;
        }
    }
}
