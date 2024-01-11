namespace Test2
{
    public class Manager : Employee
    {
        public Manager(decimal salary, string fullName, string department) :base(salary,fullName)
        {
            Department=department;
        }
        public string Department { get;private set; }
        public override void PrintDetails()
        {
            Console.WriteLine($"Id:{Id} Name:{FullName} Salary:{Salary} Department:{Department}");
        }

    }
}
