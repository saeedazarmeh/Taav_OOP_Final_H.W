using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.ValueObject;

namespace Test3
{
    public class Utility
    {

        public static void ShowBackedCars()
        {
            foreach (var car in Car.BackedCars)
            {
                    car.RentedCarDetails();
              
            }
        }
        public static void ShowRentedCars()
        {
            foreach (var car in Car.RentedCars)
            {
                    car.RentedCarDetails();
               
            }
        }

        public static void showUsers()
        {
            foreach(var user in User.users)
            {
                user.ShowUserDetails();
            }
        }

        public static Car FindRentedCar(int id)
        {
            return Car.RentedCars.FirstOrDefault(c => c.Id == id);   
        }
    }
}
