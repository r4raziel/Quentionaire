using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Car{
        public string Color { get; set; }
        public int Price { get; set; }
    }

    public class Linq_1
    {
        
        public void process()
        {
            Car[] myCars = new Car[] { 
                                  new Car { Color = "Blue", Price = 2000 } ,
                                  new Car { Color = "Red", Price = 3000 } ,
                                  new Car { Color = "Pink", Price = 5000 } ,
                                };
            //myCars.Select((v, i) => new {car = v, index = i}).First(myCondition).index;
            //myCars.Select((car, index) => new { car, index }).First(myCondition).index;

            var mycar = myCars.Select((car, index) => ( car, index)).First(t=>t.index==1);
            Console.WriteLine("Result:" + string.Join(",","abc" ));
        }
    }
}
