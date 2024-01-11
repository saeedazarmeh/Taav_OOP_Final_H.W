using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8
{
    internal class ToDoList
    {
        public static Dictionary<DateOnly, List<int>> ToDoLists = new Dictionary<DateOnly, List<int>>();
        public static void AddtoToDoList(DateOnly date, int activityId)
        {
            if (ToDoLists[date] == null)
            {
                ToDoLists.Add(date, new List<int>() { activityId });
            }
            else
            {
                if (!ToDoLists[date].Contains(activityId))
                {
                    ToDoLists[date].Add(activityId);
                }
            }
        }
        public static void removeFromToDoList(DateOnly date, int activityId)
        {
            ToDoLists[date].Remove(activityId);
        }
    }

}
