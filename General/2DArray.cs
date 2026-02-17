using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class _2DArray
    {
        public static void process()
        {
            
            int r=5;
            int[,] arr = new int[r, r];

            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < r; j++)
                {

                    arr[i, j] = r;
                }

            }

            for (int i = 0; i < r; i++)
            {
              
                for (int j = 0; j < r; j++) {

                    if (i==0 || i ==r-1)
                       Console.Write(arr[i, j] + " ");                    
                    else if(i>0 && i<r)
                      Console.Write((j!=0 && j<= r-2) ? "* " : arr[i,j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        public static void chatGPT()
        {
            for (int i = 1; i <= 5; i++)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int num)
        {
            Console.WriteLine(new string(Convert.ToChar(num.ToString()), num));
            if (num > 1)
            {
                Console.WriteLine(num + new string('*', num - 2) + num);
            }
            Console.WriteLine(new string(Convert.ToChar(num.ToString()), num));
        }
    }
}
