using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Question_Palindrome
    {
        public static bool FindPalindrome(string myString) {

            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);
            
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }

     
        public void process() {
            Console.WriteLine("Processing Plaindrome...");            
            Console.WriteLine("Result:" + string.Join(",", FindPalindrome("deed")));
        }
    }
}
