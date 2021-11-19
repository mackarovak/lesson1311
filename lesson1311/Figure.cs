using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lesson1311
{
    struct Location
    {
        public double x;
        public double y;
    }
    enum Movement
    {
        Horizontally=0,
        Vertically
    }
    class Figure: IFigureMovements
    {
        public Location location;
        public Color colour;
        public bool visibility;
        public Location Location { get { return location; } }
        public Color Color { get { return colour; } }
        public bool Visibility { get { return visibility; } }
        public void Go(Movement movement, double temp)
        {
            if (movement == 0)
            {
                location.x += temp;
            }
            else
            {
                location.y += temp;
            }
        }
        public void ChangeTheColor(Color colour)
        {
            this.colour = colour;
        }
        public void Changethestate()
        {
            visibility = !visibility;
        }
    }
}
