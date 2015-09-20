using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountXX
{
    public class Class1
    {
        public int CountXX(string str)
        {
            string newStr = "";

            foreach (var element in str)
            {
                if (element == 'x')
                {
                    newStr += element;
                }
            }

            return newStr.Length - 1;
        }
    }
}
