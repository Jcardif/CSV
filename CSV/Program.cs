using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmo = new Employees(
                "Emplyee4,Employee2,500\nEmployee3, Employee1, 800\nEmployee1,,1000\nEmployee5, Employee1, 500\n Employee2, Employee1, 500");
          Console.WriteLine(cmo.GetSalary("Employee1,"));
          Console.ReadLine();
        }
    }
}
