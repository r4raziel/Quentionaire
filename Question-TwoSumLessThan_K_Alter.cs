using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    // Given an array A of integers and integer K, return the maximun S such that there exists i < j with A[i] + A[j]=S and S < K.
    // Example 1:
    // Input: A = [34,23,1,24,75,33,54,58] , K=60
    // Output: 58
    // Explanantion:
    // We can use 34 and 24 to sum 58 which is less than 60 and there's no pait with sum of 59, therefore, the maximum sum is 58


    //Example 2:
    // Input: A = [10,20,30] , K=15
    // Output: -1

    //Explanation:
    // In this case it's not possible to get a pair sum less than 15.

    public class Question_TwoSumLessThan_K_Alter
    {
        

        public static int[] twoSumLessThanK(int[] nums, int target)
        {
            int[] result = new int[2];
            int? currentMaxLessthanTarget = null;

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {

                    int sum = nums[i] + nums[j];
                    if (currentMaxLessthanTarget == null)
                    {
                        if (sum <= target)
                        {
                            currentMaxLessthanTarget = sum;
                            result[0] = i;
                            result[1] = j;
                        }
                    }
                    else
                    {

                        if (sum <= target && sum >= currentMaxLessthanTarget)
                        {
                            currentMaxLessthanTarget = sum;
                            result[0] = i;
                            result[1] = j;

                        }
                    }

                }
            }

            return result;
        }
        public void process()
        {
            Console.WriteLine("processing question 5 alternative...");
            int[] A = { 34, 23, 1, 24, 75, 33, 54, 58 };
            int K = 60;

            int[] B = { 10, 20, 30 };
            int M = 15;
            Console.WriteLine("Result:" + string.Join(",", twoSumLessThanK(A,K)));
        }
    }
}
