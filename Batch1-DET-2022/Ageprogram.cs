using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Ageprogram
    {
        public static void Main()
        {
            int Age;
            try
            {
                Console.WriteLine("enter age btw 0- 100");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 120) 
                    throw new InvalidAge("age is invalid");
            }
            catch (InvalidAge e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            { }
        }
    }
}
