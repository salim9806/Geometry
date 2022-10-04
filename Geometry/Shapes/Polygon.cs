using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Shapes
{
    internal class Polygon
    {
        protected ushort number_of_sides;

        public Polygon(ushort numberOfSides)
        {
            number_of_sides = numberOfSides;
        }

        public Polygon()
        {
            number_of_sides = 0;
        }

        public float GetSumOfTheAngles()
        {
            return number_of_sides < 3 ? 0 : (number_of_sides - 2) * 180;
        }
    }
}
