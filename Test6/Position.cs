using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    internal class Position
    {
        public Position(int bookId)
        {
            BookId = bookId;
        }
        public int BookId { get;private set; }
        public int BookCasePositionId { get;private set; }

        public void SetBookCasePositionId(BookCase bookCase)
        {
            if (bookCase.Positions.Count == 0)
            {
                BookCasePositionId = 1;
            }
            else
            {
                BookCasePositionId = bookCase.Positions.Last().BookCasePositionId + 1;
            }
        }
    }
}
