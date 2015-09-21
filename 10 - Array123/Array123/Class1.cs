using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array123
{
    public class Class1
    {
        public bool Array123(int[] numbers)
        {
            bool subArray = false;

            for (int i = 0; i < numbers.Length - 3; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    return true;
                }

                if (numbers[numbers.Length - 1] == 3 && numbers[numbers.Length - 2] == 2 &&
                    numbers[numbers.Length - 3] == 1)
                {
                    return true;
                }
            }

            return subArray;
        }
    }
}
