using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(string name);
    }
    class BMW : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "M3")
                return 1300000;
            else if (name == "X7")
                return 9600000;
            else
                return 100000;
        }

    }
    class Hyunda : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "certa")
                return 1200000;
            else if (name == "tucson")
                return 100000;
            else
                return 780000;
        }
    }
}

//    class TestBMW
//    {
//        public static void Main()
//        {
//            BMW B = new BMW { };
//            Console.WriteLine(B.GetPrice());
//        }
//    }
//}
