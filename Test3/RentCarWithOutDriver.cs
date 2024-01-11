using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Test3.ValueObject;

namespace Test3
{
    public class RentCarWithOutDriver:Car
    {

        public RentCarWithOutDriver(int customerId, string carName, decimal rentPrice, TimeUnit timeUnit, int number, decimal guaranteePayment):base(customerId, carName,rentPrice, timeUnit, number, guaranteePayment)  
        {
         
        }

        public override void AddtoRentedCarList(Car car)
        {
            RentedCars.Add(car);
        }
        public override void RentedCarDetails()
        {
                DateTime rentingFinishTime;
                var customer = User.users.Find(u => u.Id == CustomerId);
                if (Duration.TimeUnit == TimeUnit.Hour)
                {
                    rentingFinishTime = RentingStartTime.AddHours(Duration.Number);
                }
                else
                {
                    rentingFinishTime = RentingStartTime.AddDays(Duration.Number);
                }
                Console.WriteLine($"RentedCar Without driver Id:{Id} CarName:{CarName} CostomerName:{customer.Name} CustomerOhone:{customer.PhoneNumber}  RentedStartTime:{RentingStartTime} RentingFinishTime:{rentingFinishTime} ");
            
        }
        public override void GetBackCar(Car car)
        {
            if(car != null)
            {
                ((RentCarWithOutDriver)car).IsGetBacked = true;
                BackedCars.Add(car);
                RentedCars.Remove(car);
            }

            else 
                throw new Exception("Not Found");
        } 
    }
}
