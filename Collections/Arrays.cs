using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Arrays
    {
      
        public  void ExecuteArrays()
        {
            Console.WriteLine("ARRAY");

            // Array
            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            // Array Initializer
            //int[] numbers2 = new int[3] { 1, 2, 3 };
            //Console.WriteLine(numbers2[0]);
            //Console.WriteLine(numbers2[1]);
            //Console.WriteLine(numbers2[2]);

            // Array Initializer (Simplified)
            //int[] numbers3 = { 1, 2, 3 };
            //Console.WriteLine(numbers3[0]);
            //Console.WriteLine(numbers3[1]);
            //Console.WriteLine(numbers3[2]);

            // Strings
            //string[] names = new string[3] { "Jack", "John", "Mary" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            // Length
            //Console.WriteLine($"The length of our array{numbers.Length}");

            // IndexOf()
            //var index = Array.IndexOf(numbers, 2);
            //Console.WriteLine(index);

            // Clear()
            //Array.Clear(numbers, 0, 2);
            //Console.WriteLine("Effect of Clear()");
            //foreach (var n in numbers)
            //    Console.WriteLine(n);

            // Copy()
            //int[] another = new int[3];
            //Array.Copy(numbers, another, 3);
            //Console.WriteLine("Effect of Copy()");
            //foreach (var n in another)
            //    Console.WriteLine(n);

            // Sort()
            //Array.Sort(numbers);
            //Console.WriteLine("Effect of Sort()");
            //foreach (var n in numbers)
            //    Console.WriteLine(n);

            // Reverse()
            //Array.Reverse(numbers);
            //Console.WriteLine("Effect of Reverse()");
            //foreach (var n in numbers)
            //    Console.WriteLine(n);
        }   
    public void LoopArrays()
        {
            Array.;
            string[] names = new string[3] { "Jack", "John", "Mary" };
            int[] numbers2 = new int[3] { 1, 2, 3 };

            foreach( var item in names)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
        }
    }
}
