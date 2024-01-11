using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    internal interface IBookRepository
    {
        void AddBook(Book book);
        void UpdateBooknumber(int number);
        void RemoveBook();
        void BookDetailes();
    }
}
