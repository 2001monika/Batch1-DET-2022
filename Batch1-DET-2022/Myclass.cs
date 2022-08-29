using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
     class Myclass
    {
        public static void Main()
        {
            List<Animal> Animals = new List<Animal>();
            Animals.Add(new dog());
            Animals.Add(new cat());

            foreach (Animal a in Animals)
                Console.WriteLine(a.ToString());
        }
    }
}
