using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DatesTime
{
    public class DatesTime
    {
        public void ExecuteDatesTime ()
        { 
            //DateTime
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now; //current date and time
            var today = DateTime.Today; //current date
            Console.WriteLine($"Year : {now.Year} Month : {now.Month} Hour:{now.Hour} Minutes: {now.Minute}");
            Console.WriteLine("todayToString: " + today.ToString());
            Console.WriteLine("nowToString: " + now.ToString());

            //Add
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("tomorrow : " + tomorrow);
            Console.WriteLine("yesterday : " + yesterday);

            //ToString
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine(">>>timespan Add<<<");
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(">>>timespan Subtract<<<");
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
