using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Employee_linq
    {

        public Employee_linq(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public static List<Employee_linq> GetListofEmployee_linq()
        {
            List<Employee_linq> emps = new List<Employee_linq>();
            emps.Add(new Employee_linq(1, "John", "Training"));
            emps.Add(new Employee_linq(2, "Mark", "Finance"));
            emps.Add(new Employee_linq(3, "Peter", "Technical"));
            emps.Add(new Employee_linq(4, "Bob", "Technical"));
            emps.Add(new Employee_linq(5, "Robert", "Finance"));
            emps.Add(new Employee_linq(6, "Jason", "Training"));

            return emps;
        }

        
    }
}
