using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ValueObject
{
    public class Duration
    {
        public Duration(TimeUnit timeUnit, int number)
        {
            TimeUnit = timeUnit;
            Number = number;
        }

        public TimeUnit TimeUnit { get; set; }
        public int Number { get; set; }

        public void Guard(int number)
        {
            if (number <= 0 )
            {
                throw new Exception("Salary cant be less than zero");
            }
        }
    }
    public enum TimeUnit
    {
        Hour=1,
        Day=2
    }
}
