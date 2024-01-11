namespace Test3
{
    public abstract class User
    {
        internal static List<User> users = new List<User>();

        public User(string name, string phoneNumber, string nationalCode)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            NationalCode = nationalCode;
        }
        public int Id { get; private set; }
        public string Name { get;private set; }
        public string NationalCode { get; private set; }
        public string PhoneNumber { get; private set; }
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
        public abstract void ShowUserDetails();
    }
}
