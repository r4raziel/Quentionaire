using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire.EventsDelgates
{
    public class EventProgrameOne
    {
        class Counter(int passedThreshold)
        {
            public event EventHandler? ThresholdReached;
            private readonly int _threshold = passedThreshold;
            private int _total;

            public void Add(int x)
            {
                _total += x;
                if (_total >= _threshold)
                {
                    ThresholdReached?.Invoke(this, EventArgs.Empty);
                }
            }           
        }


        public static void Process()
        {
            Counter c = new(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object? sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }
    }
}
