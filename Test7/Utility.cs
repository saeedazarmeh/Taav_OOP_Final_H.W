using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test7.ValueObject;

namespace Test7
{
    internal class Utility
    {
        public static TimeSpan CalculateAbsentShortage(DateOnly start, DateOnly end, List<Record> records, TimeSpan WorkingTime)
        {
            int days = 1;
            while (end != start)
            {
                start = start.AddDays(1);
                days++;
            }
            if (records.Count < days)
            {
                Console.WriteLine($"The Employee whre absent for {days - records.Count}days");
                return (days - records.Count) * WorkingTime;
            }
            else return new TimeSpan(0, 0, 0);
        }
        public static TimeSpan  CalculateShrtageOrOverTimeExceptWorker(TimeSpan WorkingTime,List<Record> records)
        {
            var TotalShortageOrOverTime = new TimeSpan(0, 0, 0);
            foreach (var record in records)
            {
                TimeSpan DayshortageOrOverTime = new TimeSpan(0, 0, 0);
                DayshortageOrOverTime = record.Exit - record.Enter - WorkingTime;

                Console.WriteLine($"Date:{record.Date} EnterTime:{record.Enter} ExitTime:{record.Exit} ShortageOrOverTime:{DayshortageOrOverTime}");
                 TotalShortageOrOverTime = TotalShortageOrOverTime.Add(DayshortageOrOverTime);
               
            }
            return TotalShortageOrOverTime;
        }
        public static TimeSpan CalculateShrtageOnlyWorker(TimeSpan WorkingTime, List<Record> records)
        {
            var TotalShortage = new TimeSpan(0, 0, 0);
            foreach (var record in records)
            {
                TimeSpan Dayshortage = new TimeSpan(0, 0, 0);
                if (WorkingTime > (record.Exit - record.Enter))
                {
                    Dayshortage = record.Exit - record.Enter - WorkingTime;
                }
                Console.WriteLine($"Date:{record.Date} EnterTime:{record.Enter} ExitTime:{record.Exit} Shortage:{Dayshortage}");
                TotalShortage = TotalShortage.Add(Dayshortage);
            }
            return TotalShortage;
        }

        public static TimeSpan CalculateMeassionOvertimeOnlyManager(int userId, TimeSpan WorkingTime, TimeSpan TotalShortageOrOverTime)
        {
            var missions = Mission.missions.Where(m => m.UserId == userId).ToList();

            foreach (var mission in missions)
            {

                Console.WriteLine($"Date:{mission.StartDate} UnitOfTime:{mission.Duration.TimeUnit} NumberOfTimeUnit:{mission.Duration.NumberOfTimeUnit}");
                TimeSpan missionOverTime = new TimeSpan(0, 0, 0);

                if (mission.Duration.TimeUnit == TimeUnit.Day)
                {
                    missionOverTime = WorkingTime * mission.Duration.NumberOfTimeUnit;
                }
                else
                {
                    missionOverTime = new TimeSpan(1, 0, 0) * mission.Duration.NumberOfTimeUnit;
                }
                TotalShortageOrOverTime = TotalShortageOrOverTime.Add(missionOverTime);
            }
            return TotalShortageOrOverTime;
        }
            public static List<Record> FilterRecords(DateOnly start, DateOnly end,int userId)
        {
            return Record.records.Where(r => r.Date >= start && r.Date <= end && r.UserId == userId).ToList();
        }
    }
}
