using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test7.ValueObject;

namespace Test7
{
    internal class Employee:IEmployeeService
    {
        public static List<Employee> employees=new List<Employee>();

        public Employee(string name, TimeOnly enterHour, TimeOnly exitHour)
        {
            Name = name;
            EnterHour = enterHour;
            ExitHour = exitHour;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public TimeOnly EnterHour { get; protected set; }
        public TimeOnly ExitHour { get; protected set; }
        public void SetId()
        {
            if (employees.Count > 0)
                Id = employees.Last().Id + 1;

            else Id = 1;
        }
        public static void AddToList(Employee employee)
        {
            employees.Add(employee);
        }

        public virtual void CalculateWorkingHour(DateOnly start, DateOnly end)
        {
           
        }
    }
    internal class Worker : Employee,IEmployeeService
    {
        public Worker(string name, TimeOnly enterHour, TimeOnly exitHour) : base(name, enterHour, exitHour)
        {
        }

        public override void CalculateWorkingHour(DateOnly start, DateOnly end)
        {
            Console.WriteLine("\n---------------------------------------------\n");
            var records = Utility.FilterRecords(start, end, Id);
            var WorkingTime = ExitHour - EnterHour;
            var TotalShortage =  Utility.CalculateShrtageOnlyWorker(WorkingTime,records);
            TotalShortage = TotalShortage - Utility.CalculateAbsentShortage(start, end, records, WorkingTime);
            Console.WriteLine($"TotalShortage:{TotalShortage}");
        }
    }
    internal class Engineer : Employee
    {
        public Engineer(string name, TimeOnly enterHour, TimeOnly exitHour) : base(name, enterHour, exitHour)
        {
        }
        public override void CalculateWorkingHour(DateOnly start, DateOnly end)
        {
            Console.WriteLine("\n---------------------------------------------\n");
            var records = Utility.FilterRecords(start, end, Id);
            var WorkingTime = ExitHour - EnterHour;
            var TotalShortageOrOverTime = Utility.CalculateShrtageOrOverTimeExceptWorker(WorkingTime, records);
            TotalShortageOrOverTime = TotalShortageOrOverTime - Utility.CalculateAbsentShortage(start, end, records, WorkingTime);
            Console.WriteLine($"TotalShortageOrOverTime:{TotalShortageOrOverTime}");
        }

    }
    internal class OfficeEmployee : Employee
    {
        public OfficeEmployee(string name, TimeOnly enterHour, TimeOnly exitHour) : base(name, enterHour, exitHour)
        {
        }
        public override void CalculateWorkingHour(DateOnly start, DateOnly end)
        {
            Console.WriteLine("\n---------------------------------------------\n");
            var records = Utility.FilterRecords(start, end, Id);
            var WorkingTime = ExitHour - EnterHour;
            var TotalShortageOrOverTime = Utility.CalculateShrtageOrOverTimeExceptWorker(WorkingTime, records);
            TotalShortageOrOverTime = TotalShortageOrOverTime - Utility.CalculateAbsentShortage(start, end, records, WorkingTime);
            Console.WriteLine($"TotalShortageOrOverTime:{TotalShortageOrOverTime}");
        }
    }
    internal class Manager : Employee
    {
        public Manager(string name, TimeOnly enterHour, TimeOnly exitHour) : base(name, enterHour, exitHour)
        {
        }
        public override void CalculateWorkingHour(DateOnly start, DateOnly end)
        {
            Console.WriteLine("\n---------------------------------------------\n");
           var records = Utility.FilterRecords(start, end, Id);
            var WorkingTime = ExitHour - EnterHour;
            var TotalShortageOrOverTime = Utility.CalculateShrtageOrOverTimeExceptWorker(WorkingTime, records);
            TotalShortageOrOverTime = TotalShortageOrOverTime + Utility.CalculateMeassionOvertimeOnlyManager(Id, WorkingTime, TotalShortageOrOverTime);
            TotalShortageOrOverTime = TotalShortageOrOverTime - Utility.CalculateAbsentShortage(start, end, records, WorkingTime);
            Console.WriteLine($"TotalShortageOrOverTime:{TotalShortageOrOverTime}");
        }
    
    }

}
