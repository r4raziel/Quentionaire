using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class Google_FindSum_Number
    {
        public static bool FindingSum(int[] A, int K)
        {
            HashSet<int> complements = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (complements.Contains(A[i]))
                {
                    return true;
                }
                complements.Add(K - A[i]);
            }

            return false;
        }

        public static void process()
        {
            Console.WriteLine("processing Google find sum...");
            int[] A = {1,2,3,9};
            int K = 5;

            Console.WriteLine("Result:" + string.Join(",",FindingSum(A,K)));

        }
    }
}
