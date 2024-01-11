using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test3
{

    public class Customer : User
    {

        public Customer(string name, string phoneNumber, string nationalCode) : base(name, phoneNumber, nationalCode)
        {
        }


        public override void ShowUserDetails()
        {
            Console.WriteLine($"CostomerId:{Id} Name:{Name} NationalCode:{NationalCode} PhoneNumber:{PhoneNumber}");
        }
    }
}
