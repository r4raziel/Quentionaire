using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class Axion_SumOfAmicableNumbers
    {

        //For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
        public static uint MAX_VALUE = 10000;
        public static uint sum_of_factors(uint n)
        {
            uint sum = 1;
            uint i = 2;
            for (; i < n / i; ++i)
            {
                if (n / i * i == n)
                {
                    sum += i + n / i;
                }
            }
            if (i * i == n)
                sum += i; /* add square root only once */
            return sum;
        }
        public static void AxionMain()
        {
            List<Int64> amicableList = new List<Int64>();
            for (uint num1 = 1; num1 <= MAX_VALUE; ++num1)
            {
                uint num2 = sum_of_factors(num1);
                if (num2 > num1 && num1 == sum_of_factors(num2))
                {
                    amicableList.Add(num1);
                    amicableList.Add(num2);
                    // Console.WriteLine("{0}\t\t{1}", num1, num2);

                }
            }
            var totalSum = amicableList.Sum();
            Console.WriteLine(totalSum);

        }
    }
}

