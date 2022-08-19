using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Question_1
    {
        public string[] readNumbers() {

            Console.WriteLine("Please provide string array..");
            var optr = Console.ReadLine().Split(' ');
            return optr;
        }

        public int callPoints(string[] optrArray)
        {
            List<int> myNumber = new List<int>();
            foreach (var optr in optrArray)
            {
                switch (optr)
                {
                    case "+":
                        myNumber.Add(myNumber[myNumber.Count - 2] + myNumber[myNumber.Count - 1]);
                        break;
                    case "C":
                        myNumber.Remove(myNumber.Last());
                        break;
                    case "D":
                        myNumber.Add(myNumber.Last() * 2);
                        break;

                    default:
                        myNumber.Add(int.Parse(optr));
                        break;
                }
            }
            return myNumber.Sum();
        }

        public void process() {
            Console.WriteLine("Reading question 1...");            
            Console.WriteLine("Result:"+callPoints(readNumbers()));
        }
    }
}
