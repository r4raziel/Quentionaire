using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace questionnaire
{
    public class Fovior_AgeCounting
    {
        public class Person
        {
            public int name { get; set; }
            public int  value { get; set; }
            
        }

        public static void process()
        {
            WebClient client = new WebClient();
            string s = client.DownloadString("https://coderbyte.com/api/challenges/json/age-counting");
            //string s = "{\"data\": \"key=IAfpK, age=58, key=WNVdi, age=64\"}";
            //var data = (JObject)JsonConvert.DeserializeObject(s);
            //string timeZone = data["Atlantic/Canary"].Value<string>();
            // string[] sperator = { "age"};
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(s);
            //var dictionary = JsonConvert.DeserializeObject<IEnumerable<Person>>(s).
            //     Select(p => (Id: p.name, Record: p)).
            //     ToDictionary(t => t.Id, t => t.Record);

            string[] values = dict.Values.ToArray()[0].Split(',');
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
            ageDictionary.Add("age", 0);
            


            for (int i = 1; i < values.Length; i+=2){

                var ageStr = values[i].Substring(0, 5).Trim();
                if ( ageStr== "age=")
                {
                    int age = int.Parse(values[i].Remove(0,5).Trim());
                    if (age >= 50)
                    {
                        ageDictionary["age"]++;
                    }

                }
            }
         
            Console.WriteLine(ageDictionary["age"]);
        }


    }
}
