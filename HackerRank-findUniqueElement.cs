using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class HackerRank_UniqueElement
    {
        public static int lonelyInteger(int[] numberArray)
        {

            if (numberArray.Length > 1)
            {
                int xor = numberArray[0];
                for (var i = 1; i < numberArray.Length; i++)
                {
                    xor = xor ^ numberArray[i];

                }
                return xor;

            }
            else
            {

                return numberArray[0];
            }
        }

        public static void process()
        {

            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int[] numbers = { 0,2,0 };
            int result= lonelyInteger(numbers);
            Console.WriteLine(result);
            
        }

    }
}
