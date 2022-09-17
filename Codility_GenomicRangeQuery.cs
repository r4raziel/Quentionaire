using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class Codility_GenomicRangeQuery
    {
        public int[] FindMinimalfactor(char[] Sequence, int[] P, int[] Q)
        {
            List<int> result = new List<int>();
            IDictionary<char, int> map = new Dictionary<char, int>() { {'A',1 }, { 'C', 2 }, { 'G', 3}, { 'T', 4} };
            IDictionary<char, int> countMap = new Dictionary<char, int>();

            int counter = 0;
            while (counter < P.Length)
            {
                int start = P[counter];
                int end = Q[counter];
                for ( int k = start; k <= end; k++)
                {

                    if (!countMap.ContainsKey(Sequence[k]))
                    {
                        countMap.Add(Sequence[k], map[Sequence[k]]);
                    }
                }

                result.Add(countMap.Min(x => x.Value));
                countMap.Clear();
                ++counter;
            }

            return result.ToArray();        
        }
        public void process()
        {
            Console.WriteLine("processing question 6...");
            string S = "CAGCCTA";
            char[] A = S.ToCharArray();
            int[] P = new int[]{ 2, 5, 0 };
            int[] Q = new int[] { 4, 5, 6 };

            Console.WriteLine("Result:" + string.Join(",", FindMinimalfactor(A, P,Q)));
        }
    }
}
