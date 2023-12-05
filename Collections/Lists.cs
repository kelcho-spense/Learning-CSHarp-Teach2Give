using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Lists
    {
        public void ExecuteList ()
        {
            // List

            Console.WriteLine("<<LIST>>>");

            List<string> teams = new List<string>();

            //add items to list
            teams.Add("Manchester United");
            teams.Add("Chelsea");
            teams.Add("Arsenal");
            teams.Add("Liverpool");
            teams.Add("Manchester City");

            //access items in list
            //Console.WriteLine(">>>>>>Access items in list<<<<<<");
            //Console.WriteLine(teams[0]);
            //Console.WriteLine(teams[1]);
            //Console.WriteLine(teams[2]);
            //Console.WriteLine(teams[3]);
            //Console.WriteLine(teams[4]);

            //access items in list using foreach loop
            Console.WriteLine(">>>>>>Access items in list using foreach loop<<<<<<");
            foreach (string team in teams)
            {
                Console.WriteLine(team);
            }

            //remove items from list
            Console.WriteLine(">>>>>>Remove items from list<<<<<<");
            teams.Remove("Manchester City");
            teams.RemoveAt(3);
            foreach (string team in teams)
            {
                Console.WriteLine(team);
            }

            //insert items in list
            Console.WriteLine(">>>>>>Insert items in list<<<<<<");
            teams.Insert(0, "Manchester United");

            //insert a range of items in list
            Console.WriteLine(">>>>>>Insert a range of items in list<<<<<<");
            List<string> teams2 = new List<string>()
            {
                "bayarn munich",
                "real madrid",
                "barcelona"
            };

            teams.InsertRange(0, teams2);

            foreach (string team in teams)
            {
                Console.WriteLine(team);
            }

            //sort items in list
            Console.WriteLine(">>>>>>Sort items in list<<<<<<");
            teams.Sort();
            foreach (string team in teams)
            {
                Console.WriteLine(team);
            }

            //check if item exists in list
            Console.WriteLine(">>>>>>Check if item exists in list<<<<<<");
            Console.WriteLine(teams.Contains("Manchester United"));

            // remove all items from list with a condition
            Console.WriteLine(">>>>>>Remove all items from list with a condition<<<<<<");
            Console.WriteLine(teams.RemoveAll(x => x.Contains("barcelona")));

            //find items in list with a condition
            Console.WriteLine(">>>>>>Find items in list with a condition<<<<<<");
            Console.WriteLine(teams.Find(x => x.Contains("Manchester United")));

            //


        }
    }
}
