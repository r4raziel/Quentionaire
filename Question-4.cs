using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    //find duplicate in two strings
    // input : string strA ='abcd'
    //       : string strB ='cbdae'
    // ouput : e
    // string B contain all the element
    //there is a one extra character which is e


   public class Question_4
    {
        

        public List<char> findExtraCharacter()
        {
            List<char> result = new List<char>();

            Console.WriteLine("Please provide a first string ..");
            char[] strA = Console.ReadLine().ToCharArray();

            Console.WriteLine("Please provide a second string ..");
            char[] strB = Console.ReadLine().ToCharArray();

            // store string values in map
            int[] m1 = new int[256];

            // store second string in map with frequency
            for (int i = 0; i < strB.Length; i++)
                m1[strB[i]]++;

            // store first string in map with frequency
            for (int i = 0; i < strA.Length; i++)
                m1[strA[i]]--;

            for (int i = 0; i < m1.Length; i++)
            {

                // if the frequency is 1 then this
                // character is which is added extra
                if (m1[i] == 1)
                    result.Add((char)i);                 
            }
            return result;
        }
        public void process()
        {
            Console.WriteLine("Reading question 4...");
            Console.WriteLine("Result:" + string.Join(" ", findExtraCharacter()));
        }
    }
}
