using Test7;
using Test7.ValueObject;

while (true)
{
    Console.WriteLine("Choose your Operation Index:\n" +
        "1-Add Worker\n" +
        "2-Add Engineer\n" +
        "3-Add OfficeEmployee\n" +
        "4-Add Manger\n" +
        "5-Set Enter And Exit for Employee\n" +
        "6-Set Mission for Manager\n" +
        "7-Calculate the Shortage or OverTime\n");
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Constant EnterTime");
                var enter = TimeOnly.Parse( Console.ReadLine());
                Console.WriteLine("Enter Constant ExitTime");
                var exit = TimeOnly.Parse(Console.ReadLine());
                Worker worker = new Worker(name, enter, exit);
                worker.SetId();
                Employee.AddToList(worker);
            }
            break;
        case 2:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Constant EnterTime");
                var enter = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter Constant ExitTime");
                var exit = TimeOnly.Parse(Console.ReadLine());
                Engineer engineer = new Engineer(name, enter, exit);
                engineer.SetId();
                Employee.AddToList(engineer);
            }
            break;
        case 3:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Constant EnterTime");
                var enter = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter Constant ExitTime");
                var exit = TimeOnly.Parse(Console.ReadLine());
                OfficeEmployee officeEmployee = new OfficeEmployee(name, enter, exit);
                officeEmployee.SetId();
                Employee.AddToList(officeEmployee);
            }
            break;
        case 4:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Constant EnterTime");
                var enter = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter Constant ExitTime");
                var exit = TimeOnly.Parse(Console.ReadLine());
                Manager manager = new Manager(name, enter, exit);
                manager.SetId();
                Employee.AddToList(manager);
            }
            break;
        case 5:
            {
                Console.WriteLine("Enter EmployeeId");
                var employeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Date");
                var date = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EnterTime");
                var enter = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter ExitTime");
                var exit = TimeOnly.Parse(Console.ReadLine());
                var record = new Record(employeeId, enter, exit, date);
                Record.AddRecordToLiist(record);
            }
            break;
        case 6:
            {
                Console.WriteLine("Enter ManagerId");
                var employeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Description");
                var description = Console.ReadLine();
                Console.WriteLine("Enter startDate");
                var startdate = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter UnitTime For Renting Car:1-Hour 2-Day ");
                Enum.TryParse(Console.ReadLine(), out TimeUnit timeUnit);
                Console.WriteLine("Enter Number of Time unit");
                var number = int.Parse(Console.ReadLine());
                var mission = new Mission(description,employeeId,timeUnit,number,startdate);
                Mission.AddMissionToLiist(mission);
            }
            break;
        case 7:
            {
                Console.WriteLine("Enter EmployeeId");
                var employeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter DurationStartDate");
                var start = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter DurationEndDate");
                var end = DateOnly.Parse(Console.ReadLine());
                var employee = Employee.employees.FirstOrDefault(e => e.Id == employeeId);
                employee.CalculateWorkingHour(start,end);
            }
            break;
    }
}
