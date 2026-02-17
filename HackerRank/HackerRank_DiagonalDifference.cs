using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class HackerRank_DiagonalDifference
    {
        public static void process()
        {
            //int[][] jaggedArray = new int[2][];
            //jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            //jaggedArray[1] = new int[] { 0, 2, 4, 6 };

            List<List<int>> obj = new List<List<int>>() { 
                                                          new List<int>() { 11, 2, 4 }, 
                                                          new List<int>() { 4, 5, 6 }, 
                                                          new List<int>() { 10, 8, -12 } 
                                                        };

            int[][] arrays   = obj.Select(a => a.ToArray()).ToArray();
            int[] lrDiagnoal = new int[arrays.Length];
            int[] rlDiagnoal = new int[arrays.Length];

            int j = 0;
            for (var i = 0; i < arrays.Length; i++)
            {
                lrDiagnoal[i] = j<arrays[i].Length ? arrays[i][j]:0;
                j++;
            }

            j = 0;
            for (var i = arrays.Length-1; i >= 0; i--)
            {
                rlDiagnoal[j] = arrays[i][j];
                j++;
            }

            int lrSum = lrDiagnoal.Sum();
            int rlSum = rlDiagnoal.Sum();

           Console.WriteLine( Math.Abs(lrSum - rlSum));

        }
        
    }
}
