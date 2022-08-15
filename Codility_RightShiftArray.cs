using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    //Example 1:
    //Input: A = [3,8,9,7,6]
    //     : K = 3
    //shift to right 3 times
    //Output: [9,7,6,3,8]

    public class Codility_RightShiftArray
    {

        public static int[] recursiveRotation(int[] A, int K)
        {
            int[] rotation = new int[A.Length];
            int count = 0;
            if (K == 0){
                return A;   
            }
            for (int j = A.Length - 1; j >=0; j--){
                if (count == 0)
                {
                    rotation[count] = A[j];                    
                }
                else {                    
                    rotation[count] = A[count-1];
                }
                count++;
            }
            count = 0;
            return recursiveRotation(rotation,K-1);
        
        }
        public static int[] rightshiftArray(int[] A, int K)
        {
            return recursiveRotation(A, K);
        }
        public void process()
        {
            Console.WriteLine("processing Codility rightshiftArray...");
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;

        
            Console.WriteLine("Result:" + string.Join(",", rightshiftArray(A,K)));
        }
    }
}
