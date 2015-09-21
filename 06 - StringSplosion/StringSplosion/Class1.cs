using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplosion
{
    public class Class1
    {
        public string StringSplosion(string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                newStr += str.Substring(0, i + 1);
            }

            return newStr;
        }
    }
}
