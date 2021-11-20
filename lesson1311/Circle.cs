using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1311
{
    class Circle:Point,IFigureMovements
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Ploshad()
        {
            return Math.PI * radius* radius;
        }
    }
}
 