using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
   // For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps.The number 32 has binary representation 100000 and has no binary gaps

    public class Codility_BinaryGap
    {

        public static int BinaryGap(int A)
        {
            int maxGap = 0, currentGap = 0, index=0;
            string binaryNumber = Convert.ToString(A, 2);
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '1')
                {
                    int x = index;
                    while (binaryNumber[x] == '0')
                    {
                        currentGap ++;
                        x++;
                    }                    
                    index = x + 1;
                    if (currentGap > maxGap)
                        maxGap = currentGap;
                    currentGap = 0;
                }
            
            }
            return maxGap;

        }
       
        public void process()
        {
            Console.WriteLine("processing Codility BinaryGap...");
            int A = 1041;

            Console.WriteLine("Result:" + string.Join(",", BinaryGap(A)));            

        }
    }
}
