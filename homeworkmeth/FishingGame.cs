using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkmeth
{
    class FishingGame: ITheBigRacegame
    {
        public void Testing(string name)
        {
            Console.WriteLine($"{0} играет в FishingGame", name);
        }
    }
}
