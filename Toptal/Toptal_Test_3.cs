using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Toptal_Test_3
    {
        public int[] FindMinimalfactor(char[] Sequence, int[] P, int[] Q)
        {
            return new int[] { 1,2,3};
        
        }

        public void process()
        {
            Console.WriteLine("processing question 6...");
            string S = "CAGCCTA";
            char[] A = S.ToCharArray();
            int[] P = new int[] { 2, 5, 0 };
            int[] Q = new int[] { 4, 5, 6 };

            Console.WriteLine("Result:" + string.Join(",", FindMinimalfactor(A, P, Q)));
        }
    }
}
