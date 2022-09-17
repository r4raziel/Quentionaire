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

    public class Question_FindSmallestPostitiveNumber
    {
        public static int findsmallest(int[] A)
        {

            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    numbers.Add(A[i]);
                }

            }
            for (int i = 1; i <= A.Length +1; i++)
            {
                if (!numbers.Contains(i))
                {
                    return i;
                }
            }
            return 1;
        }
    
        public void process()
        {
            Console.WriteLine("processing question 6...");
            int[] A = { 1, 3, 6, 4,1,2 };

            int[] B = { -1, -3 };
            int[] C = { 1, 2, 3 };
            Console.WriteLine("Result:" + string.Join(",", findsmallest(C)));
        }
    }
}
