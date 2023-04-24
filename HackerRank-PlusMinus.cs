using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class HackerRank_PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            string[] array = new string[3];
            double count = arr.Count;
           

            bool pos = false, neg = false, zer =false  ;


            foreach (var item in arr)
            {
                if (item < 0)
                    negative++;
                else if (item > 0)
                    positive++;
                else if (item == 0)
                    zero++;
            }

            for (int i = 0; i < 3; i++)
            {
                if (!pos && positive > 0)
                {
                    array[i] = string.Format("{0:N6}", (positive / count));
                    pos = true;
                }
                else if (!pos && positive == 0)
                {
                    array[i] = string.Format("{0:N6}", 0);
                    pos = true;
                }
                else if (!neg && negative > 0)
                {
                    array[i] = string.Format("{0:N6}", (negative / count));
                    neg = true;
                }
                else if (!neg && negative==0)
                {
                    array[i] = string.Format("{0:N6}", 0);
                    neg = true;
                }
                else if (!zer && zero > 0)
                {
                    array[i] = string.Format("{0:N6}", (zero / count));
                    zer = true;
                }
                else if (!zer && zero==0)
                {
                    array[i] = string.Format("{0:N6}", 0);
                    zer = true;
                }
            }
            

            Console.WriteLine(string.Join("\n", array));


        }

        public static void process()
        {

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

           // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> nums = new List<int>() { 1,-2,-7,9,1,-8,-5 };

            plusMinus(nums);
        }

    }
}
