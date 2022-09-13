using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    class Codility_MaxCounter
    {

        public static int[] GetCounterArray(int[] A, int N)
        {

            int maxValueReached = 0, maxValue=0;            
            int[] array = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                int operation = A[i];

                if (operation == N + 1) {
                    maxValueReached = maxValue;
                }
                else
                {
                    operation--;
                    array[operation]= Math.Max(array[operation] +1, maxValueReached +1);
                    maxValue = Math.Max(array[operation], maxValue);
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Max(array[i], maxValueReached);
            
            }


            return array;
        }

        public void process() {

            int[] A = { 3, 4, 4, 6, 1, 4, 4 };
            int[] B = { 6,6,6,6,6,6,6 };
            int N = 5;
            Console.WriteLine("Processing ...");
            Console.WriteLine("Result:" + string.Join(",", GetCounterArray(A,5)));
        }
    }
}
