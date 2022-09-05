using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Quantifiers
    {
        public static void Main()
        {
            //using All
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);



            //using Any
            string[] names1 = { "Bob", "Ned", "Amy", "Bill" };

            var result1 = names1.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result1);


            //using contains
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result2 = numbers.Contains(3);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result2);
        }
    }
}
