using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    //Example 1:
    //Input: X=100,   
    //result Time = 1h40min  

    //Exmple 2:
    //Input: X=7262
    //result Time = 2h2min

    //Example 3:
    //Input: X=5
    //result = 5sec
    public class Codility_ExtractTime
    {

        public static string ExtractTime(int n)
        {
            string timePrint = "";
            string[] timePrintArray = { "h", "m", "s" };
            int[] timeArray = new int[3];

            var numberLength = Math.Floor(Math.Log10(n) + 1);
            if (numberLength > 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (n > 60)
                    {
                        timeArray[0] = n / 60;
                        n = n % 60;
                    }
                    else
                    {
                        timeArray[1] = n;
                    }
                }
            }
            else {

                timeArray[2] = n;
            }

            for (int i = 0; i < timeArray.Length; i++)
            {
                if (timeArray[i] >0)
                {
                    if (timeArray[i] > 60)
                    {
                        timeArray[i] = timeArray[i] / 60;
                    } 

                    timePrint = timePrint + timeArray[i] + timePrintArray[i];
                }
            }
            if (timePrint != "")
                return timePrint;
            else
                return "not computable";
        }

        public void process()
            {
                Console.WriteLine("processing Codility Exctract time...");
                int K = 200;            
                Console.WriteLine("Result:" + string.Join(",", ExtractTime(K)));
            }
        }
}
