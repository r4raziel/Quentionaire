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


    public class Question_6
    {
        public static int[] findErrorNums(int[] nums)
        {
            int[] result = new int[2];

            int number = nums.GroupBy(x => x)
             .Where(g => g.Count() > 1)
             .Select(x => x.Key).ToList().FirstOrDefault();


            result[0] = number;
            int Lastposition = Array.LastIndexOf(nums, number);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == number && i+1 ==nums[i])
                {
                   var  firstPosition = Array.FindIndex(nums, x=>x==number);
                    if (firstPosition < i)
                    {
                        result[1] = firstPosition + 1;
                        break;
                    }
                    else {

                        result[1] = Lastposition + 1;
                    }
                  
                }
            }

            return result;
        }
        public void process()
        {
            Console.WriteLine("processing question 6...");
            int[] A = { 1,2,3,4,3 };

            int[] B = { 1, 2, 2 };
            Console.WriteLine("Result:" + string.Join(",", findErrorNums(A)));
        }
    }
}
