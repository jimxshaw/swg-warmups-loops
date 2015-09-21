using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count9
{
    public class Class1
    {
        public int Count9(int[] numbers)
        {
            int counter = 0;

            foreach (int element in numbers)
            {
                if (element == 9)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
