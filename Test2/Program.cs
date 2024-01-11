using Test2;

while (true)
{
    Console.WriteLine("Choose your Operation Index:\n" +
        "1-Add Employee\n" +
        "2-Add Manager\n" +
        "3-Show all Employees\n" +
        "4-Show Only Managers");
    var choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter FullName");
                var fullName = Console.ReadLine();
                Console.WriteLine("Enter salary");
                var salary = decimal.Parse(Console.ReadLine());
                var employee = new Employee(salary, fullName);
                employee.SetId();
                Employee.AddToList(employee);
                break;
            }
        case 2:
            {
                Console.WriteLine("Enter FullName");
                var fullName = Console.ReadLine();
                Console.WriteLine("Enter salary");
                var salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter department");
                var department = Console.ReadLine();
                var employee = new Manager(salary, fullName, department);
                employee.SetId();
                Employee.AddToList(employee);
                break;
            }
        case 3:
            {
                Utility.ShowAllEployee();
            }
            break;

        case 4:
            {
                Utility.ShowManager();
            }
            break;
    }
}
