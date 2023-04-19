using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class Toptal_Test_1
    {
        public int FindMinimalfactor(string[] T, string[] R)
        {
            
            IDictionary<string, int> map = new Dictionary<string, int>();
            HashSet<string> Groups = new HashSet<string>();
            string GroupName = "";
            int count = 0;            
            int totalTest = T.Length;
            
            for (int i = 0; i < R.Length; i++)
            {
                 
                 char lastChar= T[i].ToCharArray()[T[i].Length-1];
                if (char.IsLetter(lastChar))
                {
                    GroupName = T[i].Substring(0, T[i].Length - 1);

                }
                else { 
                    GroupName= T[i];
                }
                
                if (R[i] == "OK")
                {
                    ++count;                   
                    
                    if (!map.ContainsKey((GroupName)))
                    {

                        map.Add(GroupName, count);
                    }
                    else { 
                        map[GroupName] +=1 ;
                    }
                }
                count = 0;
                if (!map.ContainsKey((GroupName)))
                {
                    map.Add(GroupName, 0);
                }

            }

            
            

            int result = map.Values.Max() * 100 / map.Count;
            return result;
        }

        public void process()
        {
            Console.WriteLine("processing question 6...");
            
            string[] T = new string[] { "test1a","test2","test1b","test1c","test3" };
            string[] R = new string[] { "Wrong answer", "OK", "Runtime error", "OK", "Time Limit Exceeded" };

            Console.WriteLine("Result:" + string.Join(",", FindMinimalfactor(T,R)));
        }
    }
}
