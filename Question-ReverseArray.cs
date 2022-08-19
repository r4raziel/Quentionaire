using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
   // Given a signed 32-bit integer x, return x with its digits reversed.If reversing x causes the value to go outside the signed 32-bit integer range[-231, 231 - 1], then return 0.

   //Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
        
    
   //Example 1:

    //Input: x = 123
    //Output: 321
    //Example 2:

    //Input: x = -123
    //Output: -321
    //Example 3:

    //Input: x = 120
    //Output: 21
   public class Question_3
    {
        public int readNumber()
        {

            Console.WriteLine("Please provide a number");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public int Reverse(int num)
        {
            int  flag=0, remainder, reverse = 0, negative=-1;
            if (num < 0)
            {
                flag = 1;
                num = num * -1;
            }
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            if (flag == 1)
            {
                return reverse *= -1;
            }
            return reverse;
        }
        public void process()
        {
            Console.WriteLine("Reverse Integer");
            Console.WriteLine("Result:" + Reverse(readNumber()));
        }
    }
}
