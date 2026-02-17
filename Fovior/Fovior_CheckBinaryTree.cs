using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Fovior_CheckBinaryTree
    {

        public static bool TreeConstructor(string[] strArr)
        {
            Dictionary<int, bool> parents = new Dictionary<int, bool>();
            Dictionary<int, int> children = new Dictionary<int, int>();

            foreach (string s in strArr)
            {
                string[] parts = s.Replace("(", "").Replace(")", "").Split(',');
                int a = int.Parse(parts[0]);
                int b = int.Parse(parts[1]);

                if (parents.ContainsKey(a))
                {
                    return false;
                }
                else
                {
                    parents[a] = true;
                }

                if (children.ContainsKey(b))
                {
                    children[b]++;
                    if (children[b] > 2)
                    {
                        return false;
                    }
                }
                else
                {
                    children[b] = 1;
                }
            }

            return true;
        }

          

        public static void process()
        {
           // string[] strArr = new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" };
            string[] strBrr = new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" };
            //bool resultA = TreeConstructor(strArr);
            bool resultB = TreeConstructor(strBrr);
            //Console.WriteLine(resultA);
            Console.WriteLine(resultB);

            // Console.WriteLine("processing Codility Exctract time...");
            //string[] A = { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" };            

            // Console.WriteLine("Result:" + string.Join(",", findOddOneOut(B)));
        }


    }
}
