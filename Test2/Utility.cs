using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public static class Utility
    {
        public static void ShowAllEployee()
        {
            foreach (var employee in Employee.employees)
            {
                    employee.PrintDetails();
            }
        }

        public static void ShowManager()
        {
            foreach (var employee in Employee.employees)
            {
                if (employee is Manager)
                {
                    employee.PrintDetails();
                }
            }
        }
    }
}
