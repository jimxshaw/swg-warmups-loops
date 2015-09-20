using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryOther
{
    public class Class1
    {
        public string EveryOther(string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i += 2)
            {
                newStr += str[i];
            }

            return newStr;
        }
    }
}
