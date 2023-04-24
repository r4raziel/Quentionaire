using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class HackerRank_StringAnagram
    {

        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            List<int> result = new List<int>();
            foreach (var queryItem in query)
            {
                char[] ch2 = queryItem.ToLower().ToCharArray();
                int count = 0;
                Array.Sort(ch2);

                foreach (var dicItem in dictionary)
                {

                    char[] ch1 = dicItem.ToLower().ToCharArray();
                    int[] m1 = new int[256];
                    Array.Sort(ch1);

                    for (int i = 0; i < ch1.Length; i++){
                        m1[ch1[i]]++;
                    }
                    for (int i = 0; i < ch2.Length; i++){
                        m1[ch2[i]]--;
                    }
                    count++;
                    for (int i = 0; i < m1.Length; i++)
                    {
                        if (m1[i] != 0)
                        {
                            count--;
                            break;

                        }

                    }
                }
               
                result.Add(count <0 ? 0: count);
                
            }
            return result;

        }

        public static void process()
        {

            List<string> dictionary = new List<string>() { "hack", "a", "rank", "khac", "ackh","kran","rankhacker","a","ab","ba","stairs","raits" };
            List<string> query = new List<string>() { "a","nark","bs","hack","stair" };

            List<int> result = stringAnagram(dictionary, query);
            Console.WriteLine("Result:" + string.Join(",", result));
        }
    }
}
