using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1311
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            ACypher aCypher = new ACypher();
            BCypher bCypher = new BCypher(Convert.ToInt32(Console.ReadLine()));
            string str = Console.ReadLine();
            string afterstr = aCypher.encode(str);
            Console.WriteLine(afterstr);
            afterstr = bCypher.decode(afterstr);
            Console.WriteLine(afterstr);
            Console.WriteLine("Задание 2");

            Console.ReadKey();
        }
    }
}
