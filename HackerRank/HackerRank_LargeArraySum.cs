using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionaire
{
    public class hackerRank_LargeArraySum
    {

        public static long ArraySum(List<long> n)
        {
            long sum = 0;
            for (int i = 0; i < n.Count; i++)
            {
                sum += n[i];
            }

            return sum;
        }

        public static void process()
        {
            Console.WriteLine("processing...");
            List<long> n = new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            Console.WriteLine("Result:" + string.Join("", ArraySum(n)));
        }
    }
}