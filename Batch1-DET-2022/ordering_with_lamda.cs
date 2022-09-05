using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ordering_with_lamda
    {
        public static void Main()
        {
            #region "orderbynumbers"
            //int[] numbers = { 8, 5, 9, 1 };

            //var result = numbers.OrderBy(x => x);

            //foreach (int number in result)
            //{
            //    Console.WriteLine("{0}", number);
            //}
            //Console.ReadLine();
            #endregion

            #region "orderbydescending"

            //string[] names = { "moni", "sindhu", "nithya", "arusha", "shipla" };
            //var result1 = names.OrderByDescending(n => n);

            //foreach(string name in result1)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region "reverse char"
            //char[] characters = { 'M', 'O', 'N', 'I' };
            //var result2 = characters.Reverse();

            //foreach(char character in result2)
            //{
            //    Console.WriteLine(character);
            //}
            #endregion

            #region "usingthenby"
            //string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
            //              "Athens", "Beijing", "Seoul" };

            //var result3 = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //foreach (string capital in result3)
            //{

            //    Console.WriteLine(capitals);
            //}
            #endregion

            #region "using_thenbydescending"

            var dates = new DateTime[]
        {
            new DateTime(2015, 3, 1),
            new DateTime(2014, 7, 1),
            new DateTime(2013, 5, 1),
            new DateTime(2015, 1, 1),
            new DateTime(2015, 7, 1),
        };


            var result4 = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            foreach (DateTime date in result4)
            {
                Console.WriteLine(date);
            }
            #endregion

        }
    }
}
