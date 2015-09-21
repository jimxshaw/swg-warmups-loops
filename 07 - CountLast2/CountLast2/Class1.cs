using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLast2
{
    public class Class1
    {
        public int CountLast2(string str)
        {
            string last2 = str.Substring(str.Length - 2);
            string theFront = str.Remove(str.Length - 2);
            int counter = 1;

            for (int i = 0; i < theFront.Length - 2; i++)
            {
                if (str.Substring(i, i + 1) == last2)
                {
                    counter++;
                }
            }

            return counter;

        }
    }
}
