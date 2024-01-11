using Test3;
using Test3.ValueObject;

while (true)
{
    Console.WriteLine("Choose your Operation Index:\n" +
        "1-Add Customer\n" +
        "2-Add Driver\n" +
        "3-Show Users\n" +
        "4-Rent Car Without Driver\n" +
        "5-Rent Car With Driver\n" +
        "6-GetBack Car\n" +
        "7-Show Rented Cars\n" +
        "8-Show GetBacked Cars\n");
    var choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter NationalCode");
                var nationalCode = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber");
                var phone = Console.ReadLine();
                var user = new Customer(name, phone, nationalCode);
                user.SetId();
                User.AddUserToList(user);
               
            }
            break;
        case 2:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter NationalCode");
                var nationalCode = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber");
                var phone = Console.ReadLine();
                var user = new Driver(name, phone, nationalCode);
                user.SetId();
                User.AddUserToList(user);
             
            }
            break;
        case 3:
            {
                Utility.showUsers();
            }
            break;
        case 4:
            {
                Console.WriteLine("Enter carName");
                var carName = Console.ReadLine();
                Console.WriteLine("Enter customerId");
                var customerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rentPrice");
                var rentPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter UnitTime For Renting Car:1-Hour 2-Day ");
                Enum.TryParse(Console.ReadLine(),out TimeUnit timeUnit);
                Console.WriteLine("Enter Time Unit Number");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter guaranteePayment");
                var guaranteePayment = decimal.Parse(Console.ReadLine());
                var car = new RentCarWithOutDriver(customerId,carName,rentPrice,timeUnit,number,guaranteePayment);
                car.SetId();
                car.AddtoRentedCarList(car);
                
            }
            break;
        case 5:
            {
                Console.WriteLine("Enter carName");
                var carName = Console.ReadLine();
                Console.WriteLine("Enter customerId");
                var customerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter driverrId");
                var driverId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rentPrice");
                var rentPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter UnitTime For Renting Car:1-Hour 2-Day ");
                Enum.TryParse(Console.ReadLine(), out TimeUnit timeUnit);
                Console.WriteLine("Enter Time Unit Number");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter guaranteePayment");
                var guaranteePayment = decimal.Parse(Console.ReadLine());
                var car = new RentCarWithDriver(customerId, carName, rentPrice, timeUnit, number, guaranteePayment,driverId);
                car.SetId();
                car.AddtoRentedCarList(car);
                
            }
            break;
        case 6:
            {
                Console.WriteLine("Enter CarRentedId");
                var carRentedId = int.Parse(Console.ReadLine());
                var car=Utility.FindRentedCar(carRentedId);
                car.GetBackCar(car);
            }
            break;
        case 7:
            {
                Utility.ShowRentedCars();
            }
            break;
        case 8:
            {
                Utility.ShowBackedCars();
            }
            break;
    }
}
