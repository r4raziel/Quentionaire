using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    class Codility_TapeEquilibrium
    {
        public int findSmallesValue( int [] A) {

            int rightSum = 0, differ = 0, leftSum = 0; 
            int? minValue=null; 
            
       
            for (int i = 0; i < A.Length; i++)
                rightSum += A[i];

            for (int j = 0; j < A.Length-1; j++)
            {
                rightSum -= A[j];
                leftSum  += A[j];
                differ    = Math.Abs(rightSum - leftSum);             

                if (differ < minValue || minValue==null)
                {
                    minValue = differ;
                }
            
            }
            return minValue.Value;
        }

        public void process()
        {

            int[] A = { 3, 1, 2, 4, 3};
            int[] B = { 1000, -1000 };       
            Console.WriteLine("Processing ...");
            Console.WriteLine("Result:" + string.Join(",", findSmallesValue(A)));
        }
    }
}
