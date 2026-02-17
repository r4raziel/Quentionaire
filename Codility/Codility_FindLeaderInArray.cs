using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    //Example A={2,2,2,2,2,3,4,4,4,6}    
    //the function should return −1, because the value that occurs most frequently in the array, 2, occurs five times, and 5 is not more than half of 10.

    //Example B= {1,1,1,1,50}
    //the function should return 1

    public class Codility_FindLeaderInArray
    {

        public static int FindLeader(int[] A)
        {
            int n = A.Length;
            int[] L = new int[n + 1];
            L[0] = -1;
            for (int i = 0; i < n; i++)
            {
                L[i + 1] = A[i];
            }
            int count = 0;
            int pos = (n + 1) / 2;
            int candidate = L[pos];
            for (int i = 1; i <= n; i++)
            {
                if (L[i] == candidate)
                    count = count + 1;
            }
            //if (count > pos) 
              if (2 * count > n)
                return candidate;
                    
            return (-1);
        }

        public static void process()
            {
                Console.WriteLine("processing Codility Exctract time...");
                int[] A = { 2, 2, 2, 2, 2, 3, 4, 4, 4, 6 };
            int[] B = { 1,1,1,1,50 };
            Console.WriteLine("Result:" + string.Join(",", FindLeader(B)));
            }
        }
}
