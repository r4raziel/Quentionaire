using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class CodeSignal_Practise_1
    {
        public static void process()
        {
            int[] array = { 98};
            List<int> result = new List<int>();
            Array.Sort(array);

            Dictionary<int,int> numsDictionary = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                var decmialnumber = (decimal)array[i]/10;                

                var part = Decimal.ToInt16((Math.Truncate(decmialnumber)));
                if (part == 0) {
                    if (numsDictionary.ContainsKey(array[i]))
                    {
                        numsDictionary[array[i]] = numsDictionary[array[i]] + 1;
                    }
                    else {

                        numsDictionary.Add(array[i], 1);
                    }

                }
                else {

                    if (numsDictionary.ContainsKey(part)) {
                        numsDictionary[part] = numsDictionary[part] + 1;
                    }
                    else {
                        numsDictionary.Add(part, 1);
                    }
                    var first2DecimalPlaces = Decimal.ToInt16((decmialnumber - part) * 10);

                    if (numsDictionary.ContainsKey(first2DecimalPlaces))
                    {
                        numsDictionary[first2DecimalPlaces] = numsDictionary[first2DecimalPlaces] + 1;
                    }
                    else
                    {

                        numsDictionary.Add(first2DecimalPlaces,1);       
                    }
                }
                    
                   
            }
            int currentMax = 0;
            var totalLength = numsDictionary.Count;
            for (int i = 0; i < totalLength; i++)
            { 
                var max =numsDictionary.MaxBy(kvp => kvp.Value);
               
                if (currentMax == 0)
                    currentMax = max.Value;
                else if (max.Value < currentMax)
                    break;

                numsDictionary.Remove(max.Key);
                result.Add(max.Key);
            }
            
            result.Sort();
           
            Console.WriteLine(string.Join(",", result));

        }
    }
}
