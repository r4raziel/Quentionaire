using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    class Codility_PassCars
    {

        public static int PassingCars(int[] A) {

            int eastBound =0, passingCars=0;
            for(int i=0; i< A.Length; i++)
            {
                if (A[i] == 0)
                    eastBound++;
                else
                {
                    passingCars += eastBound;
                    if (passingCars > 1000000000)
                        return -1;
                }

            }
         
            return passingCars;


        }

        public void process()
        {
            Console.WriteLine("processing Codility Passing Cars...");
            int[] A = { 0,1,0,1,1};

            Console.WriteLine("Result:" + string.Join(",", PassingCars(A)));

        }
    }
}
