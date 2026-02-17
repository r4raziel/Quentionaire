using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace questionnaire
{
    
    public class Fovior_JsonCleaning
    {
        public class Person
        { 
            public string first { get; set; }
            public string middle { get; set; }
            public string last { get; set; }
        }
        public class Education { 
            public string highschool { get; set; }
            public string colledge { get; set;}
        }

        public class Fovior
        {
            public Person name { get; set; }
            public string age { get; set; }
            public string DOB { get; set; }
            public string[] hobbies { get; set; }


        }

        public class IgnoreEmptyStringsConverter : JsonConverter
        {
            #region Methods

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(string);
            }


            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                                            JsonSerializer serializer)
            {
                var theValue = reader.Value?.ToString();
                //return !string.IsNullOrWhiteSpace(theValue) ? theValue : null;
                if (string.IsNullOrEmpty(theValue) || theValue == "-" || theValue == "N/A")                
                    return null;
                return theValue;
                
            }
            

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
               /* if (!string.IsNullOrWhiteSpace(value.ToString()))
                {
                    JToken token = JToken.FromObject(value.ToString(), serializer);
                    token.WriteTo(writer);
                    return;
                }

                writer.WriteNull();*/
                throw new NotImplementedException();
            }           

            #endregion
        }
        
        public static void process()
        {
            WebClient client = new WebClient();
            string s = client.DownloadString("https://coderbyte.com/api/challenges/json/json-cleaning");
           
            var serializerSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                Converters = new List<JsonConverter> { new IgnoreEmptyStringsConverter() }
            };

            var Foviorperson = JsonConvert.DeserializeObject<Fovior>(s, serializerSettings);            
            var Jsonperson = JsonConvert.SerializeObject(Foviorperson, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore});



        }


    }
}
