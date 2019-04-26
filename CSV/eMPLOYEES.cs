using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    public class Employees
    {
        public  List<Employee> employees { get; set; }
        public Employees(string info)
        {
            List<string> lines = new List<string>();
            using (StringReader sr = new StringReader(info))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            employees=new List<Employee>();
            foreach (var line in lines)
            {
                var str = line.Split(',');
                var emp = new Employee
                {
                    Id=str[0],
                    ManagerId = !string.IsNullOrEmpty(str[1]) ? str[1] : " ",
                    Salary = Convert.ToInt32(str[2])
                };
                employees.Add(emp);
            }

        }

        public long GetSalary(string id)
        {
            var x = 0;
            foreach (var employee in employees)
            {
                if (string.Equals(employee.ManagerId,id))
                    x += employee.Salary;
            }

            return x;
        }
    }
}
