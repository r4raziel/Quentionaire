using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class Codility_CountDiv
    {

        public int CountDiv(int A, int B, int K)
        {
            int result = (int)((B / K) - Math.Ceiling((double)A / K)) + 1;
            return result > 0 ? result : 0;
        }

        public void process()
        {
            Console.WriteLine("processing Codility count division...");
            int A=6, B=11, K=2;

            Console.WriteLine("Result:" + string.Join(",", CountDiv(A,B,K)));

        }
    }
}
