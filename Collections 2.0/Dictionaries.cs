using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2._0
{
    public class Dictionaries
    {
        public void ExecuteDictionaries ()  
        { 
            //Create a Dictionary
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("001", "John");
            dictionary.Add("002", "Peter");
            dictionary.Add("003", "Mary");
            dictionary.Add("004", "Sara");

            //Display the dictionary
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //Create a Dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>()
            {
               {"UK", "London, Manchester, Birmingham"},
               {"USA", "Chicago, New York, Washington"},
               {"India", "Mumbai, New Delhi, Pune" }
            };


            //Add a new key-value pair
            cities.Add("Australia", "Sydney, Melbourne, Brisbane");
            Console.WriteLine("Display Dictionaries initialized using collection-initializer syntax");
            foreach (KeyValuePair<string, string> kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            //Accessing a Dictionary
            Console.WriteLine("Accessing a Dictionary");
            Console.WriteLine("Cities in UK are: {0}", cities["UK"]);

            //Accessing a Dictionary using TryGetValue
            Console.WriteLine("Accessing a Dictionary using TryGetValue");
            string result;
            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine("Cities in France are: {0}", result);
            }
            else
            {
                Console.WriteLine("Key is not found");
            }

            //ContainsKey
            Console.WriteLine("ContainsKey");
            if (cities.ContainsKey("India"))
            {
                Console.WriteLine("Cities in India are: {0}", cities["India"]);
            }

            
        }
    }
}
