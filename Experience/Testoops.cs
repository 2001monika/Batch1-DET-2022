using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingments
{
    internal class Testoops
    {
        public static void Main()
        {
            oops e = new oops(22855, "moni", new DateOnly(2020, 8, 1));
            Console.WriteLine($"year of experience{e.GetYearsofExp()}");

        }
    }
}
