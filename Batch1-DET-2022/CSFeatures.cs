using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"hai {name}"); };
            //action.invoke("Moni")

            Action<string,string> action1 = (string s1,string s2) => { Console.WriteLine($"hai{s1},"+ 
                $"you said {s2}");};

            Action<string,string,string> action2 = (string a1,string a2,string a3) => { Console.WriteLine($"hi{a1},"+
                $"you said{a2},"+ $"and ur staying in{a3}");};

            action.Invoke("Moni");
            action1.Invoke("Moni", "I'm in Blr");
            action2.Invoke("Moni", " ur in blr", " PG");
        }
    }
}
