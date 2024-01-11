using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test6.ValueObject;

namespace Test6
{
    internal class Book : IBookRepository, IBookService
    {
        internal static List<Book> books = new List<Book>();
        public Book(string name, int number)
        {
            Guard(number);
            Name = name;
            InitialNumber = number;
            RemainNumber = number;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int InitialNumber { get; protected set; }
        public int RemainNumber { get; protected set; }
        public int? BookCaseId { get; protected set; }

        public void SetId()
        {
            if (books.Count > 0)
                Id = books.Last().Id + 1;

            else Id = 1;
        }

        public void AddBook(Book book)
        {
            book.SetId();
            books.Add(book);
        }

        public void AddBookToBookCase(int bookCaseId)
        {
            BookCaseId = bookCaseId;
            var bookCase = BookCase.BookCases.FirstOrDefault(b => b.Id == bookCaseId);
            if(!bookCase.Positions.Contains(new Position(Id)))
            {
                var position = new Position(Id);
                position.SetBookCasePositionId(bookCase);
                bookCase.Positions.Add(position);
            }
           

        }

        public void BookDetailes()
        {
            var bookCase = BookCase.BookCases.FirstOrDefault(b => b.Id == BookCaseId);
            var posirion = bookCase.Positions.First(p => p.BookId == Id);
            Console.WriteLine($"id:{Id} Name:{Name} InitialNumber:{InitialNumber} RemainingNumber:{RemainNumber} BookCase:{bookCase.Name} Position:{posirion.BookCasePositionId}");
        }

        public void RemoveBook()
        {
            if (RemainNumber != InitialNumber)
            {
                Console.WriteLine("This book is Deleted but has rented By:");
                Test6.RentBook.rentedBooks.Where(b => b.BookId == Id).ToList().ForEach(b =>
                {
                    var user = User.users.FirstOrDefault(u => u.Id == b.UserId);
                    Console.WriteLine($"{user.Name} {user.PhoneNumber} ");
                }
              );
            }
            var book = books.FirstOrDefault(b => b.Id == Id);
            var bookCase = BookCase.BookCases.FirstOrDefault(b => b.Id == BookCaseId);
            var positon = bookCase.Positions.FirstOrDefault(p => p.BookId == Id);
            bookCase.Positions.Remove(positon);
            books.Remove(book);
        }

        public void UpdateBooknumber(int number)
        {
            Guard(number);
            RemainNumber = RemainNumber+ number;
            InitialNumber = InitialNumber+ number;
        }

        public void GetBackBook(int rentBookId)
        {
            RemainNumber += 1;
            var rentBook = Test6.RentBook.rentedBooks.FirstOrDefault(r => r.Id == rentBookId);
            rentBook.GetBackBook();
        }
        public void RentBook(int userId, TimeUnit timeUnit, int numberOfUnitTime)
        {
            if (RemainNumber == 0)
            {
                Console.WriteLine("this book has rented and there is no more");
            }
            else
            {
                RemainNumber -= 1;
                var rentBook = new RentBook(Id, userId, timeUnit, numberOfUnitTime);
                rentBook.SetId();
                Test6.RentBook.AddRentBookToList(rentBook);
            }

        }
        public void Guard(int number)
        {
            if (number <= 0) throw new Exception("number should be greater than 0");
        }
    }
}
