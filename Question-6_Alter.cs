using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    //Example 1:
    //Input: nums = [1,2,3,4,3]
    //Output: [3,5]

    //Example 2:
    //Input: nums = [1,2,2]
    //Output: [2,3]


    public class Question_6_Alter
    {
        public static int[] findErrorNums(int[] nums)
        {
            int[] result = new int[2];
            int[] count = new int[nums.Length +1];
            int repeatedNumber = 0;
            int missingNumber = 0;

            for (int i = 0; i < nums.Length; i++)
             {
                count[nums[i]]++;
                if (count[nums[i]] == 2)
                {
                    repeatedNumber = nums[i];
                    break;
                }
            
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (count[i] == 0)
                {
                    missingNumber = i;
                    break;
                }
            
            }

            result[0] = repeatedNumber;
            result[1] = missingNumber;

            return result;
        }
        public void process()
        {
            Console.WriteLine("processing question 6...");
            int[] A = { 1, 3, 3, 4, 2 };

            int[] B = { 1, 2, 2 };
            Console.WriteLine("Result:" + string.Join(",", findErrorNums(A)));
        }
    }
}
