using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    internal class Square : Polygon, IPlaneShape
    {
        private float sideLength;

        public Square(float sideLength)
        {
            this.sideLength = sideLength;
            number_of_sides = 4;
        }

        public double GetArea()
        {
            return Math.Pow(sideLength, 2);
        }

        public double GetCircumference()
        {
            return sideLength * 4;
        }
    }
}
