using System;
using System.Collections.Generic;
using System.Linq;

namespace questionnaire
{
    public class FooBar
    {
       
        private Dictionary<int, string> rules = new Dictionary<int, string>();
        public void AddRule(int divisor, string output)
        {
            rules[divisor] = output;
        }

        public string[] Generate(int n)
        {
            string[] array = new string[n];

            for (int i = 1; i <= n; i++)
            {
                string result = "";

                foreach (var rule in rules.OrderBy(r => r.Key))
                {
                    if (i % rule.Key == 0)
                    {
                        result += rule.Value;
                    }
                }

                array[i - 1] = result == "" ? i.ToString() : result;
            }
            return array;
        }

        public string[] fooBar(int n)
        {
            int[] numbers = new int[n];
            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                string result = "";
                
                if (numbers[i] % 3 == 0)
                {
                    result += "foo";
                }
                if (numbers[i] % 5 == 0)
                {
                    result += "bar";
                }
                if (numbers[i] % 7 == 0)
                {
                    result += "jazz";
                }
                
                array[i] = result == "" ? numbers[i].ToString() : result;
            }

           array = Generate(n);
           return array;
        }

        public void process()
        {
            Console.WriteLine("processing...");
     
            // Configure rules
            var fooBar = new FooBar();
            fooBar.AddRule(3, "foo");
            fooBar.AddRule(4, "baz");
            fooBar.AddRule(5, "bar");
            fooBar.AddRule(6, "jazz");
            fooBar.AddRule(7, "huzz");
            

            Console.WriteLine("Result:" + string.Join(",", fooBar.fooBar(120)));          
            
        }
    }
}
