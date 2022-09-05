using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Linq
    {
        public static void Main()
        {
            //the three parts of linq query: deffered execution
            //1.data source
            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            //2. query creation . sql type
            // example of deffered execution
            //var numQuery = from num in numbers  //select num from numbers
            //               select num;

            //lamda exp
            //var numQuery = numbers.Select(x => x);

            // ex of early execution
            //var numQuery = (from num in numbers
            //                select num).ToList();


            //var numQuery = from num in numbers  //select num from numbers using where clause
            //               where num>102
            //               select num;


            //lamda exp
            var numQuery = numbers.Where(x => x > 102);

            numbers.Add(200);
            //3.query execution

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0}", num);
                //num.dump(); // this for linq not for VS
            }
            Console.ReadLine();
        }
    }
}
