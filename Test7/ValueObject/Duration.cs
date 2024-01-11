using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7.ValueObject
{
    public class Duration
    {
        public Duration(TimeUnit timeUnit, int numberOfTimeUnit)
        {
            TimeUnit = timeUnit;
            NumberOfTimeUnit = numberOfTimeUnit;
        }

        public TimeUnit TimeUnit { get; set; }
        public int NumberOfTimeUnit { get; set; }

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
