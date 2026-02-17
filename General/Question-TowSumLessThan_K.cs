using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    // Given an array A of integers and integer K, return the maximun S such that there exists i < j with A[i] + A[j]=S and S < K.
    // Example 1:
    // Input: A = [34,23,1,24,75,33,54,8] , K=60
    // Output: 58
    // Explanantion:
    // We can use 34 and 24 to sum 58 which is less than 60 and there's no pait with sum of 59, therefore, the maximum sum is 58


    //Example 2:
    // Input: A = [10,20,30] , K=15
    // Output: -1

    //Explanation:
    // In this case it's not possible to get a pair sum less than 15.

    public class Question_5
    {
        

        public static int twoSumLessThanK(int[] A, int K)
        {
            int result = Int32.MinValue;
            int? currentMaxLessThanK =null;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    int sum = A[i] + A[j];
                    if (currentMaxLessThanK == null)
                    {
                        if (sum < K)
                        {
                            currentMaxLessThanK = sum;
                        }
                    }
                    else {

                        if (sum < K && sum > currentMaxLessThanK) {

                            currentMaxLessThanK = sum;
                        }
                    
                    }
                
                }
            
            }

            if (currentMaxLessThanK == null)
                result = -1;
            else
                result = currentMaxLessThanK.Value;
            return result;
        }
        public void process()
        {
            Console.WriteLine("processing question 5...");
            int[] A = { 34, 23, 1, 24, 75, 33, 54, 8 };
            int K = 60;

            int[] B = { 10, 20, 30 };
            int M = 15;
            Console.WriteLine("Result:" + string.Join(",", twoSumLessThanK(A,K)));
        }
    }
}
