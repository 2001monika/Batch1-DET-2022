using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public interface ICar
    {
        int GetPrice(string name);
    }
    public class BMW : ICar
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
}
