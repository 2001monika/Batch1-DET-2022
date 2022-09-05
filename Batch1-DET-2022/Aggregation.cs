using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Aggregation
    {
        public static void Main()
        {
            // aggregate simpleoperations
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a + b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);


            //using average
            int[] numbers1 = { 10, 11, 11, 10};

            var result1 = numbers1.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result1);


            //using count
            string[] names = { "moni", "manasa", "sheela", "navya", "anusha" };
            var result2 = names.Count();

            Console.WriteLine("count is:");
            Console.WriteLine(result2);


            //using Max 
            int[] numbers3 = { 1, 2, 3, 4, 5 };
            var result3 = numbers3.Max();

            Console.WriteLine("Max  num is:");
            Console.WriteLine(result3);


            //using Min
            int[] numbers4 = { 1, 2, 3, 4 };
            var result4 = numbers4.Min();
            Console.WriteLine("Min num is");
            Console.WriteLine(result4);


            //using sum
            int[] numbers5 = { 2, 5, 10 };

            var result5 = numbers5.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result5);






        }
    }
}
