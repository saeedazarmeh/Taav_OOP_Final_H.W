using Test3.ValueObject;

namespace Test3
{
    public class RentCarWithDriver : Car
    {
        public RentCarWithDriver(int customerId, string carName, decimal rentPrice, TimeUnit timeUnit, int number, decimal guaranteePayment, int driverId) : base(customerId, carName, rentPrice, timeUnit, number, guaranteePayment)
        {
            DriverId = driverId;
        }
        public int DriverId { get; set; }  

        public override void AddtoRentedCarList(Car car)
        {
            RentedCars.Add(car);
        }
        public override void RentedCarDetails()
        {
                DateTime rentingFinishTime;
                var customer = User.users.Find(u => u.Id == CustomerId)!;
                var driver = User.users.Find(u => u.Id == DriverId)!;
                if (Duration.TimeUnit == TimeUnit.Hour)
                {
                    rentingFinishTime = RentingStartTime.AddHours(Duration.Number);
                }
                else
                {
                    rentingFinishTime = RentingStartTime.AddDays(Duration.Number);
                }
                Console.WriteLine($"RentedCar With driver Id:{Id} CarName:{CarName} CostomerName:{customer.Name} CustomerOhone:{customer.PhoneNumber}  RentedStartTime:{RentingStartTime} RentingFinishTime:{rentingFinishTime} driver:{driver.Name} driverPhone:{driver.PhoneNumber}");
        }
        public override void GetBackCar(Car car)
        {
            if (car != null)
            {
                ((RentCarWithDriver)car).IsGetBacked = true;
                BackedCars.Add(car);
                RentedCars.Remove(car);
            }

            else
                throw new Exception("Not Found");
        }
    }
}
