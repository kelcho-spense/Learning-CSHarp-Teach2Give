using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2._0
{
    public class HashTables
    {
        public void ExecuteHashtables() 
        {
            //Create a hashtable
            Hashtable ht = new Hashtable();
            ht.Add("001", "John");
            ht.Add("002", "Peter");
            ht.Add("003", "Mary");
            ht.Add("004", "Sara");
            ht.Add("005", "Smith");

            //Display the hashtable
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            // creating a hashtable using collection-initializer syntax
            var cities = new Hashtable()
            {
               {"UK", "London, Manchester, Birmingham"},
               {"USA", "Chicago, New York, Washington"},
               {"India", "Mumbai, New Delhi, Pune" }
            }; 
            
            // adding a new key-value pair
            cities.Add("Australia", "Sydney, Melbourne, Brisbane");
            Console.WriteLine("");
            foreach (DictionaryEntry kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            //Add Dictionary in Hashtable
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("001", "John");
            dictionary.Add("002", "Peter");
            dictionary.Add("003", "Mary");
            dictionary.Add("004", "Sara");

            Hashtable newhashtable = new Hashtable(dictionary);

            //Display the hashtable
            foreach (DictionaryEntry item in newhashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //Add SortedList in Hashtable
            SortedList sortedList = new SortedList();
            sortedList.Add("001", "John");
            sortedList.Add("002", "Peter");
            sortedList.Add("003", "Mary");
            sortedList.Add("004", "Sara");

            Hashtable newhashtable2 = new Hashtable(sortedList);

            //Display the hashtable
            foreach (DictionaryEntry item in newhashtable2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //Remove elements from Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("001", "John");
            hashtable.Add("002", "Peter");
            hashtable.Add("003", "Mary");

            //Remove element with key "002"
            hashtable.Remove("002");
            
            // remove using ContainsKey

            if (hashtable.ContainsKey("003"))
            {
                hashtable.Remove("003");
            }

            //Display the hashtable
            Console.WriteLine("Display the remaining hashtable after removing");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


        }
    }
}
