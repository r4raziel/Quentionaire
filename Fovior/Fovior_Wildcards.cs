using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Fovior_WildCards
    {
        static bool Wildcards(string first, string second)
        {

            // If we reach at the end of both strings, 
            // we are done 
            if (first.Length == 0 && second.Length == 0)
                return true;

            if (first.Length == 1 && first[0] == '+')
            {
                if (second.Length > 1)
                {
                    return false;
                }
                else if (second.Length == 1 && char.IsLetter(second[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {

                // Make sure that the characters after '+' 
                // are present in second string. 
                // This function assumes that the first 
                // string will not contain two consecutive '+' 
                if (first.Length > 1 && first[0] == '+'
                    && second.Length == 0)
                    return false;

                // If the first string contains '$', 
                // or current characters of both strings match 
                if ((first.Length > 1 && first[0] == '$')
                    || (first.Length != 0 && second.Length != 0
                        && first[0] == second[0]))
                    return Wildcards(first.Substring(1),
                                 second.Substring(1));

                // If there is *, then there are two possibilities 
                // a) We consider current character of second string 
                // b) We ignore current character of second string. 
                if (first.Length > 0 && first[0] == '+')
                    return Wildcards(first.Substring(1), second.Substring(1))
                        || Wildcards(first, second.Substring(1));
            }
            return false;
        }

        public static void process()
        {
            string subject = "abcd11";
            string pattern = "+++++";
            Console.WriteLine(Wildcards(pattern, subject));
        }
    }
}
