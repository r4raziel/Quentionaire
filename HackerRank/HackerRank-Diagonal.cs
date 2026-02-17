using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class HackerRank_Diagonal
    {

        public static int dignoalDifference(List<List<int>> arr)
        {

            int[][] arrays =arr.Select(a => a.ToArray()).ToArray();


            return arrays.Length;



        }

        public static void process()
        {

            List<List<int>> array = new List<List<int>>() { 
                                                            new List<int>() { 11, 2, 4 } ,
                                                            new List<int>() { 4, 5, 6 } , 
                                                            new List<int>() { 10, 8, -12 } 
                                                          };
            int result = dignoalDifference(array);
            Console.WriteLine(result);

        }
    }
}
