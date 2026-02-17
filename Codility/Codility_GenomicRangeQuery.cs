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
            int[] A = new int[Sequence.Length];
            int[] C = new int[Sequence.Length];
            int[] G = new int[Sequence.Length];
            int[] T = new int[Sequence.Length];

            int a=0,c=0,g=0, t=0;

            for (int i = 0; i < Sequence.Length; i++)
            {

                if (Sequence[i] == 'A') ++a;
                else if (Sequence[i] == 'C') ++c;
                else if (Sequence[i] == 'G') ++g;
                else    { ++t; }
                A[i] = a;
                C[i] = c;
                G[i] = g;
                T[i] = t;
            }


            for (int i = 0; i < P.Length; i++)
            {
                if (P[i] == Q[i])
                {
                    if (Sequence[P[i]] =='A') result.Add(1);
                    else if (Sequence[P[i]] =='C') result.Add(2);
                    else if (Sequence[P[i]] == 'G') result.Add(3);
                    else result.Add(4);

                }
                else if (A[P[i]] < A[Q[i]] || Sequence[P[i]] == 'A') result.Add(1);
                else if (C[P[i]] < C[Q[i]] || Sequence[P[i]] == 'C') result.Add(2);
                else if (G[P[i]] < G[Q[i]] || Sequence[P[i]] == 'G') result.Add(3);
                else if ( Sequence[P[i]] == 'T') result.Add(4);

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
