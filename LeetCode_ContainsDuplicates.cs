using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class LeetCode_ContainsDuplicates
    {

        public bool findDuplicate(int[] numberArray)
        {
            bool exists = false;
            var query = numberArray.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .ToDictionary(x => (x.Key), y => y.Count());

            if (query.Count == 0) { return exists; }
            var luckNumbers = query.MaxBy(x => x.Value);
            if (luckNumbers.Value > 1) { exists = true; }

            return exists;
        }

        public void process()
        {
            int[] A = new int[] { 1, 2, 3, 1 };

            int[] B = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            int[] C = new int[] { 1, 2, 3, 1 };

            Console.WriteLine("processing leet code...");
            Console.WriteLine("Result:" + findDuplicate(C));
        }
    }
}
