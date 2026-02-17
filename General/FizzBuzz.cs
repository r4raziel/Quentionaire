using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class FizzBuzz
    {
        public static void fizzBuzz(int n)
        {
            int[] numbers = new int[n];
            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            for(int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0){
                    array[i]="FizzBuzz";
                }
                else if (numbers[i] % 3 == 0 && numbers[i] % 5 != 0){
                    array[i] = "Fizz";
                }
                else if (numbers[i] % 3 != 0 && numbers[i] % 5 == 0){                    
                    array[i] = "Buzz";
                }
                else{
                    array[i]=numbers[i].ToString();
                }
            }

            Console.WriteLine(string.Join("\n", array));
            Console.ReadLine();
        }        

        public static void process()
        {
            Console.WriteLine("processing...");
            int n = 15;           
            fizzBuzz(n);
        }
    }
}
