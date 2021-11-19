using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1311
{
    public interface ICypher
    {
        string decode(string strochka1);
        string encode(string strochka2);
    }
}
