using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    

    public class Question_FrogRiver
    {
        public static int findJumpNumber(int[] nums, int X)
        {
            HashSet<int> jumps = new HashSet<int>();

            for (int i = 1; i <=X; i++)
             {
               jumps.Add(i);
            
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (jumps.Remove(nums[i]))
                {
                    if (jumps.Count == 0)
                    {
                        return i;
                    }
                }
            
            }

            return 1;
        }
        public void process()
        {
            Console.WriteLine("processing question 6...");
            int[] A = { 1,3,1,4,2,3,5,4};

            int[] B = { 1, 2, 2 };
            Console.WriteLine("Result:" + string.Join(",", findJumpNumber(A,5)));
        }
    }
}
