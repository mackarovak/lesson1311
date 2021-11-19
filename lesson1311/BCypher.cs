using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1311
{
    class BCypher: alfavit,ICypher
    {
        public int i;
        public BCypher(int i)
        {
            this.i = i;
        }
        public string encode(string strochka1)
        {
            string cyphertext = "";
            for (int i = 0; i < strochka1.Length; i++)
            { cyphertext = cyphertext + (char)(strochka1[i] + i); }
            return cyphertext;
        }
        public string decode(string strochka2)
        {
            string plaintext = "";
            for (int i = 0; i < strochka2.Length; i++)
            { plaintext = plaintext + (char)(strochka2[i] - i); }
            return plaintext;
        }
    }
}
