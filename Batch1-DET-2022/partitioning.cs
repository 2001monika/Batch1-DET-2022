using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class partitioning
    {
        public static void Main()
        {
            //using Skip
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.Skip(3);


            foreach (string word in result)
            {
                Console.WriteLine(word);
            }



            //using SkipWhile

            string[] words1 = { "one", "two", "three", "four", "five", "six" };

            var result1 = words1.SkipWhile(w => w.Length == 4);

            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result1)
            {
                Console.WriteLine(word);
            }



            //using Take

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result2 = numbers.Take(6);

            Console.WriteLine("Takes the first 6 numbers only:");
            foreach (int number in result2)
            {

                Console.WriteLine(number);
            }



            //using TakeWhile

            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result3 = numbers1.TakeWhile(n => n < 5);

            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result3)
            {
                Console.WriteLine(number);
            }
        }
    }
}
