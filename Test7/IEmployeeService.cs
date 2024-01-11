using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    internal interface IEmployeeService
    {
        void CalculateWorkingHour(DateOnly start, DateOnly end);
    }
}
