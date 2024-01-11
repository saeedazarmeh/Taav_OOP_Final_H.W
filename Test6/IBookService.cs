using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test6.ValueObject;

namespace Test6
{
    internal interface IBookService
    {
        void AddBookToBookCase( int bookCaseId);
        void RentBook(int UserId, TimeUnit timeUnit, int number);
        void GetBackBook(int rentBookId);
    }
}
