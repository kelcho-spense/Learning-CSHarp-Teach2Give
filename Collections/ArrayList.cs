using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ArrayList
    {
        public void ExecuteArrayList()
        {
            Console.WriteLine("ARRAYLIST");
            //ArrayList
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.Remove(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("start indexof");
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("start count");
            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine("start removing");

            numbers.Remove(1); //removes first 1 in the list

            //FOREACH:Get Values
            foreach (var number in numbers)
                Console.WriteLine(number);

            //FOR:Get Index
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
            //Insert an Element into a Specified Position

            //insert 10 at the end of the list
           numbers.Insert(numbers.Count, 10);
            foreach (var number in numbers)
                Console.WriteLine(number);


        }
    }
}
