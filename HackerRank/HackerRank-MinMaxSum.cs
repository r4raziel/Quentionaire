using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class HackerRank_MinMaxSum
    {
        public static void MinMaxSum(List<Int64> arr)
        {
            var array = arr.ToArray();
            Array.Sort(array);

            Int64[] numSum = new Int64[2];
            Int64 smallSum = new Int64();
            Int64 maxSum   = new Int64();

            for (int i = 0; i < array.Length-1; i++)
            {
                smallSum = smallSum + array[i];
            
            }
            for (int i = 1; i < array.Length; i++)
            {
                maxSum = maxSum + array[i];

            }

            numSum[0] = smallSum;
            numSum[1] = maxSum;
            Console.WriteLine(string.Join(" ", numSum));


        }

        public static void process()
        {

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

           // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<Int64> nums = new List<Int64>() { 7,69,2,221,8974 };

            MinMaxSum(nums);
        }

    }
}
