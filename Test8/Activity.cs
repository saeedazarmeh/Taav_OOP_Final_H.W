using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test8.Enum;

namespace Test8
{
    internal class Activity
    {
        protected  IActivityService _activityService=new ActivityService();
        public static List<Activity> activities = new List<Activity>();

        public Activity(DateOnly date, TimeOnly start, TimeOnly end)
        {
            _activityService.HasInterSection(date, start, end);
            Date = date;
            Start = start;
            End = end;
        }

        public int Id { get; protected set; }
        public DateOnly Date { get; protected set; }
        public TimeOnly Start { get; protected set; }
        public TimeOnly End { get; protected set; }
        public void SetId()
        {
            if (activities.Count > 0)
                Id = activities.Last().Id + 1;

            else Id = 1;
        }
        public static void AddToList(Activity activity)
        {
            activities.Add(activity);
        }
        public void EditActivity(DateOnly date,TimeOnly start,TimeOnly end)
        {
            if (Date != date)
            {
                ToDoList.removeFromToDoList(Date,Id);
                ToDoList.AddtoToDoList(date, Id);
            }
            Date = date;
            Start = start;
            End = end;

        }
        public static void RemoveActivity(Activity activity)
        {
            ToDoList.ToDoLists[activity.Date].Remove(activity.Id);
            activities.Remove(activity);
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Id:{Id} Start:{Start} End:{End}");
        }


    }
    internal class CookinfFood : Activity
    {
        public CookinfFood(DateOnly date, TimeOnly start, TimeOnly end, string foodName) : base(date, start, end)
        {
            FoodName = foodName;
        }

        public string FoodName { get;private set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"Id:{Id} Start:{Start} End:{End} FoodName:{FoodName}");
        }
    }
    internal class EatingFood : Activity
    {
        public EatingFood(DateOnly date, TimeOnly start, TimeOnly end,string foodName) : base(date, start, end)
        {
            FoodName = foodName;
        }

        public string FoodName { get;private set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"Id:{Id} Start:{Start} End:{End} FoodName:{FoodName}");
        }
    }
    internal class Sporting : Activity
    {
        public Sporting(DateOnly date, TimeOnly start, TimeOnly end,Sport sport) : base(date, start, end)
        {
            Sport = sport;
        }

        public Sport Sport { get;private set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"Id:{Id} Start:{Start} End:{End} Sport:{Sport}");
        }
    }
    internal class Programming : Activity
    {
        public Programming(DateOnly date, TimeOnly start, TimeOnly end, string description) : base(date, start, end)
        {
            Description=description;
        }

        public string Description { get;private set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"Id:{Id} Start:{Start} End:{End} Description:{Description}");
        }
    }
    internal class Sleeping : Activity
    {
        public Sleeping(DateOnly date, TimeOnly start, TimeOnly end) : base(date, start, end)
        {
        }
    }
    internal class HangingOut : Activity
    {
        public HangingOut(DateOnly date, TimeOnly start, TimeOnly end, string description) : base(date, start, end)
        {
            Description = description;
        }

        public string Description { get;private set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"Id:{Id} Start:{Start} End:{End} Description:{Description}");
        }

    }
    internal class ReedingBook : Activity
    {
        public ReedingBook(DateOnly date, TimeOnly start, TimeOnly end, string bookName) : base(date, start, end)
        {
            BookName = bookName;
        }

        public string BookName { get;private set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"Id:{Id} Start:{Start} End:{End} BookName:{BookName}");
        }
    }
}
