using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Employee
    {
        public static List<Employee> employees { get; set; }=new List<Employee>();

        public Employee( decimal salary,string fullName)
        {
            Guard(salary);
            Salary = salary;
            FullName = fullName;
        }

        public int Id { get;private set; }
        public string FullName { get;protected set; }
        public decimal Salary { get;protected set; }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Id:{Id} Name:{FullName} Salary:{Salary}");
        }
        public static void AddToList(Employee employee)
        {
            employees.Add(employee);
        }
        public void SetId()
        {
            if (employees.Count > 0)
                Id=employees.Last().Id+1;

            else Id=1;
        }
        public void Guard(decimal salary)
        {
            if(salary < 0)
            {
                throw new Exception("Salary cant be less than zero");
            }
        }
    }
}
