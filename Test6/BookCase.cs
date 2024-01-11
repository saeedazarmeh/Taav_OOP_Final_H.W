using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Test6
{
    internal class BookCase
    {
        internal static List<BookCase> BookCases = new List<BookCase>();

        public BookCase(string name)
        {
            Name = name;
        }

        public int Id { get;private set; }
        public string Name { get;private set; }
        public List<Position>Positions { get; set; }=new List<Position>();

        public void SetId()
        {
            if (BookCases.Count > 0)
                Id = BookCases.Last().Id + 1;

            else Id = 1;
        }
        public static void AddBookCasesToList(BookCase bookCase)
        {
            BookCases.Add(bookCase);
        }
    }
}
