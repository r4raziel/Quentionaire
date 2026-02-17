using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class HackerRannk_SimpleArraySum
    {
        public static int ArraySum(List<int> n)
        {
            int sum = 0;
            for (int i = 0; i < n.Count; i++)
            {
                sum += n[i];
            }

            return sum;
        }

        public static void process()
        {
            Console.WriteLine("processing...");
            List<int> n = new List<int> { 1, 2, 3, 4, 10, 11 };
            Console.WriteLine("Result:" + string.Join("", ArraySum(n)));
        }
    }
}
