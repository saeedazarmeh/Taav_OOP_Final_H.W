using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test6.ValueObject;

namespace Test6
{
    internal class RentBook
    {
        internal static List<RentBook> rentedBooks = new List<RentBook>();

        public RentBook(int bookId, int userId , TimeUnit timeUnit, int numberOfTimeUnit)
        {
            BookId = bookId;
            UserId = userId;
            Duration = new Duration(timeUnit, numberOfTimeUnit);
        }

        public int Id { get;private set; }
        public int BookId { get; private set; }
        public int UserId { get; private set; }
        public DateTime StartRentDate { get;private set; }= DateTime.Now;
        public Duration Duration { get;private set; }
        public bool isGetBacked { get;private set; }=false;
        public void SetId()
        {
            if (rentedBooks.Count > 0)
                Id = rentedBooks.Last().Id + 1;

            else Id = 1;
        }
        public static void AddRentBookToList(RentBook rentBook)
        {
            rentedBooks.Add(rentBook);
        }

        public void GetBackBook()
        {
            isGetBacked = true;
        }
    }
}
