using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Testemp_experience
    {
        public static void Main()
        {
            emp_experience e = new emp_experience(22855, "moni", new DateOnly(2020, 8, 1));
            Console.WriteLine($"year of experience{e.GetYearsofExp()}");

        }
    }
}
