using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lesson1311
{
    interface IFigureMovements
    {
        void Go(Movement movement,double temp);
        void ChangeTheColor(Color colour);
        void Changethestate();
    }
}
