using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    internal class Circle : IPlaneShape
    {
        private float radius;

        public Circle(float radius) 
            => this.radius = radius;

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetCircumference()
        {
            return Math.PI * 2 * radius;
        }

        public double GetVolymAsSphere()
        {
            return ( 4 * Math.PI * Math.Pow((double)radius, 3) ) / 3;
        }
    }
}
