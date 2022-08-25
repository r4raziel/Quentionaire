using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    
    public class Codility_FrogRiver
    {

        public static int solutionFrogRiver(int X, int[] A)
        {
            HashSet<int> nums = new HashSet<int>();
            for (int i = 1; i <=X; i++)
            {
                nums.Add(i);
            }

            for (int i =0; i< A.Length; i++)
            {

                if (nums.Remove(A[i]))
                {
                    if (nums.Count == 0)
                    { 
                     return i;
                    }
                }
            
            }

            return -1;
        }
       
        public void process()
        {
            Console.WriteLine("processing Codility frog river...");
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };
            int X = 5;
            
            Console.WriteLine("Result:" + string.Join(",", solutionFrogRiver(X,A)));
        }
    }
}
