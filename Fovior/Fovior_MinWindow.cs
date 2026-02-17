using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace questionnaire
{
    public class Fovior_MinWindow
    {

        public static string MinWindow(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]))
                {
                    dict[t[i]]++;
                }
                else
                {
                    dict.Add(t[i], 1);
                }
            }

            var res = string.Empty;
            var len = s.Length + 1;
            var start = 0;
            var count = t.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]]-- > 0)
                    {
                        count--;
                    }
                }

                while (count == 0)
                {
                    if (len > i - start + 1)
                    {
                        len = i - start + 1;
                        res = s.Substring(start, len);
                    }

                    if (dict.ContainsKey(s[start]))
                    {
                        if (dict[s[start]]++ >= 0)
                        {
                            count++;
                        }
                    }

                    start++;
                }
            }

            return res;
        }
        public static void process()
        {
         
            string[] A = new string []{ "aaffhkksemckelloe", "fhea" };
            
            Console.WriteLine("Result:" + string.Join("", MinWindow(A[0], A[1])));
        }
    

    }
}
