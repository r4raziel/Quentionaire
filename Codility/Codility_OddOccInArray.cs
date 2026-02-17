using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    //Example 1:
    //Input: A=[9,3,9,3,7,9]   
    //result= 7  

   
    public class Codility_OddOccInArray
    {

        public static int findOddOneOut(int[] numberArray)
        {
            
            if (numberArray.Length > 1)
            {
                int xor = numberArray[0];
                for (var i = 1; i <numberArray.Length; i++)
                {
                    xor = xor ^ numberArray[i];
                    
                }
                return xor;

            }
            else {

                return numberArray[0];
            }

        }

        public static void process()
            {
                Console.WriteLine("processing Codility Exctract time...");
                int[] A = { 9, 3, 9, 3, 5 };
                int[] B = { 4, 3, 4, 2, 2 };

            Console.WriteLine("Result:" + string.Join(",", findOddOneOut(B)));
            }
        }
}
