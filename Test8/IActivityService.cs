using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8
{
    internal interface IActivityService
    {
         void HasInterSection(DateOnly date, TimeOnly start, TimeOnly end);
    }
    internal class ActivityService : IActivityService
    {
        public void HasInterSection(DateOnly date, TimeOnly start, TimeOnly end)
        {
            var activityIdList = ToDoList.ToDoLists[date];
            foreach (var activityId in activityIdList)
            {
                var activity = Activity.activities.FirstOrDefault(a => a.Id == activityId);
                if((start>activity.Start && start<activity.End) || (end > activity.Start && end < activity.End) || (start < activity.Start && start > activity.End))
                {
                    throw new Exception("This Time has Filled By other Activity");
                }
            }
        }
    }
}
