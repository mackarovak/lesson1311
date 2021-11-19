using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkmeth
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 4;
            List<Country> Countries = new List<Country>(count);
            Countries.Add(new Country("Poссия"));
            Countries.Add(new Country("Франция"));
            Countries.Add(new Country("Китай"));
            Countries.Add(new Country("Украина"));
            foreach (Country country in Countries)
            {
                country.Testingstart(new FishingGame());
                country.Testingstart(new Gamesonthebeach());
                country.Testingstart(new TheBullTrialGame());
                country.Testingstart(new TheMousetrapGame());
                country.Testingstart(new ThePostmanGame());
                country.Testingstart(new TheSeaGame());
                country.Testingstart(new TheSlideGame());
            }
        }
    }
}