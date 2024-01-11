using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class Driver:User
    {

        public Driver(string name, string phoneNumber, string nationalCode):base(name, phoneNumber, nationalCode)
        {
        }

        public override void ShowUserDetails()
        {
                Console.WriteLine($"DriverId:{Id} Name:{Name} NationalCode:{NationalCode} PhoneNumber:{PhoneNumber}");
            
        }
    }
}
