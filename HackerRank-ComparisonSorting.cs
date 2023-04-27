using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class HackerRank_ComparisonSorting
    {

        public static void process()
        {
            int[] unSorted = new List<int> { 63,25,73,1,98,73,56,84}.ToArray();
            int[] m = new int[100];           

            for (int i = 0; i < unSorted.Length; i++){
                m[unSorted[i]]++;
            }

            Console.WriteLine(m);
            
        }
    }
}
