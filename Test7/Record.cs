using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    internal class Record
    {
        public static List<Record> records = new List<Record>();
        public Record(int userId, TimeOnly enter, TimeOnly exit,DateOnly date)
        {
            UserId = userId;
            Enter = enter;
            Exit = exit;
            Date = date;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public TimeOnly Enter { get; set; }
        public TimeOnly Exit { get; set; }
        public DateOnly Date { get; set; } =DateOnly.FromDateTime( DateTime.Now.Date);
        public void SetId()
        {
            if (records.Count > 0)
                Id = records.Last().Id + 1;

            else Id = 1;
        }
        public static void AddRecordToLiist(Record record)
        {
            records.Add(record);
        }
    }
}
