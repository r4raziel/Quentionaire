using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class YieldTest
    {
        public IEnumerable<int> Integers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }
        
        public void process()
        {
            int[] IntegersArray = new int[] { 1, 2, 4, 8, 10 };
            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }
            foreach (int i in IntegersArray)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
