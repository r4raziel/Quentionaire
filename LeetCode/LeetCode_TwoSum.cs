using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;



namespace questionnaire
{
    public class LeetCode_TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return [dict[complement], nums[i]];
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
            }
            return Array.Empty<int>();
        }

        public static void process()
        {
            //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            //You may assume that each input would have exactly one solution, and you may not use the same element twice.
            //You can return the answer in any order.   


            //Example 1:

            //Input: nums = [2, 7, 11, 15], target = 9
            //Output: [0, 1]
            //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
            //Example 2:

            //Input: nums = [3, 2, 4], target = 6
            //Output: [1, 2]
            //Example 3:

            //Input: nums = [3, 3], target = 6
            //Output: [0, 1]

            int[] A = [2, 7, 11, 15];

            int[] B = [3,2,4];

            int[] C = [3, 2, 3];

            int[] D = [1, 8, 4, 9, 2];
            string[] E = ["apple", "banana", "cherry", "date", "elderberry"];
            string[] F = ["fig", "grape", "honeydew", "kiwi", "lemon", "mango", "nectarine", "orange", "papaya", "quince"];
            string[] G = ["Iron Man", "Captain America", "Thor", "Hulk", "Black Widow", "Hawkeye", "Spider-Man", "Doctor Strange", "Black Panther", "Captain Marvel"];
            string[] H = ["Superman", "Batman", "Wonder Woman", "The Flash", "Green Lantern", "Aquaman", "Cyborg", "Shazam", "Green Arrow", "Martian Manhunter"];
            Console.WriteLine("processing leet code...");
            Console.WriteLine("Result:" + string.Join(",", TwoSum(C, 6)) );
        }
    }
}
