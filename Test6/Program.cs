using Test6;
using Test6.ValueObject;

while (true)
{

    Console.WriteLine("Choose your Operation Index:\n" +
        "1-Add User\n" +
        "2-Add BookCase\n" +
        "3-Add Book\n" +
        "4-Add Book to BookCase\n" +
        "5-Update Book\n" +
        "6-Delete Book\n" +
        "7-Rent Book\n" +
        "8-GetBack Book\n" +
        "9-Show Book details\n");
    var choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber");
                var phone = Console.ReadLine();
                var user = new User(name, phone);
                user.SetId();
                User.AddUserToList(user);
            }
            break;
        case 2:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                var bookCase=new BookCase(name);
                bookCase.SetId();
                BookCase.AddBookCasesToList(bookCase);
            }
            break;
        case 3:
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Book numbers");
                var number = int.Parse(Console.ReadLine());
                var book=new Book(name, number);
                book.AddBook(book);
            }
            break;
        case 4:
            {
                Console.WriteLine("Enter bookId");
                var bookId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bookCaseId");
                var bookCaseId = int.Parse(Console.ReadLine());
                var book = Book.books.FirstOrDefault(b => b.Id == bookId);
                book.AddBookToBookCase(bookCaseId);
            }
            break;
        case 5:
            {
                Console.WriteLine("Enter bookId");
                var bookId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Book numbers");
                var number = int.Parse(Console.ReadLine());
                var book = Book.books.FirstOrDefault(b => b.Id == bookId);
                book.UpdateBooknumber(number);
            }
            break;
        case 6:
            {
                Console.WriteLine("Enter bookId");
                var bookId = int.Parse(Console.ReadLine());
                var book = Book.books.FirstOrDefault(b => b.Id == bookId);
                book.RemoveBook();
            }
            break;
        case 7:
            {
                Console.WriteLine("Enter bookId");
                var bookId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter UserId");
                var userId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter UnitTime For Renting Car:1-Day 2-Mounth ");
                Enum.TryParse(Console.ReadLine(), out TimeUnit timeUnit);
                Console.WriteLine("Enter Number of Time unit");
                var number = int.Parse(Console.ReadLine());
                var book = Book.books.FirstOrDefault(b => b.Id == bookId);
                book.RentBook(userId,timeUnit,number);

            }
            break;
        case 8:
            {
                Console.WriteLine("Enter bookId");
                var bookId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rentBookId");
                var rentBookId = int.Parse(Console.ReadLine());
                var book = Book.books.FirstOrDefault(b => b.Id == bookId);
                book.GetBackBook(rentBookId);
            }
            break;
        case 9:
            {
                Console.WriteLine("Enter bookId");
                var bookId = int.Parse(Console.ReadLine());
                var book = Book.books.FirstOrDefault(b => b.Id == bookId);
                book.BookDetailes();
            }
            break;
    }
}

