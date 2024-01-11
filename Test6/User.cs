using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    public class User
    {
        internal static List<User> users = new List<User>();

        public User(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; private set; }
        public string Name { get;private set; }
        public string PhoneNumber { get;private set; }
        public void SetId()
        {
            if (users.Count > 0)
                Id = users.Last().Id + 1;

            else Id = 1;
        }
        public static void AddUserToList(User user)
        {
            users.Add(user);
        }
    }
}
