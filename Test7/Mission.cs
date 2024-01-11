using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test7.ValueObject;

namespace Test7
{
    internal class Mission
    {
        public static List<Mission> missions=new List<Mission>();
        public Mission(string description,int userId, TimeUnit timeUnit, int numberOfTimeUnit,DateOnly startDate)
        {
            Description = description;
            UserId = userId;
            Duration = new Duration(timeUnit, numberOfTimeUnit);
            StartDate = startDate;
        }

        public int Id { get;private set; }
        public int UserId { get;private set; }
        public string Description { get;private set; }
        public Duration Duration { get;private set; }
        public DateOnly StartDate { get;private set; } = DateOnly.FromDateTime(DateTime.Now.Date);
        public void SetId()
        {
            if (missions.Count > 0)
                Id = missions.Last().Id + 1;

            else Id = 1;
        }
        public static void AddMissionToLiist(Mission mission)
        {
            missions.Add(mission);
        }
    }
}
