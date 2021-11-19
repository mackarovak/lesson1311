using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1311
{
    class Rectangle: Point
    {
        public double Width;
        public double Length;
        public Rectangle(double Width,double Length)
        {
            this.Width = Width;
            this.Length = Length;
        }
        public override double Ploshad()
        {
            return Width * Length;
        }
    }
}
