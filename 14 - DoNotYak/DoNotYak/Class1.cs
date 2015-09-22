using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNotYak
{
    public class Class1
    {
        public string DoNotYak(string str)
        {
            string newStr = "";

            if (str.Contains("yak"))
            {
                newStr += str.Replace("yak", "");
            }

            return newStr;
        }
    }
}
