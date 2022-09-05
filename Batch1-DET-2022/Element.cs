using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Element
    {
        public static void Main()
        {
            //using elementAt
            string[] words = { "One", "Two", "Three" };

            var result = words.ElementAt(1);

            Console.WriteLine("Element at index 1 in the array is:");
            Console.WriteLine(result);


            //usin ElementAtOrDefault
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);


            //using first()
            string[] fruits = { "Banana", "Apple", "Orange" };

            var result1 = fruits.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result1);


            //using firstconditional
            string[] names = { "Monikag", "Manasa", "Anusha" };

            var result2 = names.First(c => c.Length == 6);

            Console.WriteLine("First element with a length of 6 characters:");
            Console.WriteLine(result2);



            //using firstordefault
            string[] countries = { "Denmark", "Sweden", "Norway" };
            string[] empty = { };

            var result3 = countries.FirstOrDefault();

            var resultEmpty = empty.FirstOrDefault();

            Console.WriteLine("First element in the countries array contains:");
            Console.WriteLine(result3);

            Console.WriteLine("First element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);


            //using last
            int[] numbers = { 7, 3, 5 };

            var result4 = numbers.Last();

            Debug.WriteLine("Last number in array is:");
            Debug.WriteLine(result4);


            //using lastordefault
            int[] numbers1 = { 1, 2, 3, 4 };
            int[] empty1 = { };
            var result5 = numbers1.LastOrDefault();
            var resultempty1 = empty1.LastOrDefault();
            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result);

           Console.WriteLine("Last element in the empty array does not exist:");
           Console.WriteLine(resultEmpty == null);


            //using lastordefault(conditional)
            string[] words1 = { "one", "two", "three" };

            var result6 = words1.LastOrDefault(w => w.Length == 3);

            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result6);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);


            //using single
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] emptyele = { };

            var result7 = names1.Single();
            Console.WriteLine(result7);

            try
            {
                // This will throw an exception because array contains no elements
                var resultemptyele = emptyele.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result8 = names3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            //using singleordefault
            string[] name1 = { "Peter" };
            string[] name3 = { "Peter", "Joe", "Wilma" };
            string[] Empty = { };

            var res1 = name1.SingleOrDefault();

            var resEmpty = Empty.SingleOrDefault();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(res1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resEmpty == null);

            try
            {
                // This will throw an exception as well because array contains more than one element
                var res3 = name3.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
