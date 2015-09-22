using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltPairs
{
    public class Class1
    {
        public string AltPairs(string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (i % 4 == 0)
                {

                    newStr += str.Substring(i, 1);
                    newStr += str.Substring(i + 1, 1);
                }
            }

            if (str.Length%2 == 0)
            {
                return newStr;
            }

            return newStr + str.Substring(str.Length - 1);
        }
    }
}
