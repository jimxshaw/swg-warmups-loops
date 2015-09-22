using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array667
{
    public class Class1
    {
        public int Array667(int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] == 6 && numbers[i + 1] == 6) || (numbers[i] == 6 && numbers[i + 1] == 7))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
