using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    //Given an array of integers,a lucky number
    //Example 1:

    //input: arr= [2,2,3,4]
    //output: 2

    //Explanation:
    //the only lucky number in the array is 2 because it occurs twice within the array which is equal to its value 2


    //Example 2:
    //input: arr = [1,2,2,3,3,3]

    // output:3
    //1,2,3 are all lucky numbers and the largest is returned.

    //Example 3:
    //there are no lucky numbers in the array beacuse 2 occurs 3 times and 3 occurs twice in the array.
   public class Question_FindDuplicateNumber
    {
        public string[] readNumbers()
        {

            Console.WriteLine("Please provide string array..");
            var numberArray = Console.ReadLine().Split(' ');
            return numberArray;
        }

        public int findDuplicate(string[] numberArray)
        {
            int maxValue = -1;
            var query = numberArray.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .ToDictionary(x => int.Parse(x.Key), y => y.Count());

            if (query.Count == 0) { return maxValue; }                     
            var luckNumbers = query.Where(x => x.Key == x.Value).Select(x => x.Key).ToList();
            if (luckNumbers.Count > 0) { maxValue = luckNumbers.Max(); }

            return maxValue;
        }
        public void process()
        {
            Console.WriteLine("Reading question 2...");
            Console.WriteLine("Result:" + findDuplicate(readNumbers()));
        }
    }
}
