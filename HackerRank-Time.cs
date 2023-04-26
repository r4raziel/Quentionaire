using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class HackerRank_Time
    {
        public static void timeConversion(string s)
        {

            DateTime myDate = DateTime.Parse(s);
            Console.WriteLine(myDate.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
        }

        public static void process()
        {

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string strDate = "12:01:00PM";

            timeConversion(strDate);
            
        }

    }
}
