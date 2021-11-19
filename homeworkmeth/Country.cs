using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkmeth
{
    class Country
    {
        public string country;
        public Country(string country)
        {
            this.country = country;
        }
        public void Testingstart(ITheBigRacegame theBigRacegame)
        {
            theBigRacegame.Testing(country);
        }
    }
}
