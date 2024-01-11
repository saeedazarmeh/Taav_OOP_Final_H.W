using Test8;
using Test8.Enum;
while (true)
{
    Console.WriteLine("Choose your Operation Index:\n" +
    "1-Add SportActivity\n" +
     "2-Add CookinfFoodActivity\n" +
     "3-Add EatingFoodActivity\n" +
     "4-Add ProgrammingActivity\n" +
     "5-Add SleepingActivity\n" +
     "6-Add HangingOutActivity\n" +
     "7-Add ReadingActivity\n" +
     "8-Edit Activity\n" +
     "9-Remove Activity\n" +
     "10-Whatch to do List Base Date");
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter SPort Type: 1-Swiming 2-BodyBuilding 3-Running");
                Enum.TryParse(Console.ReadLine(), out Sport sport);
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly dete = DateOnly.Parse(Console.ReadLine());
                var sportingActivity = new Sporting(dete, start, end, sport);
                sportingActivity.SetId();
                Activity.AddToList(sportingActivity);
                ToDoList.AddtoToDoList(sportingActivity.Date, sportingActivity.Id);

            }
            break;
        case 2:
            {
                Console.WriteLine("Enter FoodName");
                var name = Console.ReadLine();
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly dete = DateOnly.Parse(Console.ReadLine());
                var cookingActivity = new CookinfFood(dete, start, end, name);
                cookingActivity.SetId();
                Activity.AddToList(cookingActivity);
                ToDoList.AddtoToDoList(cookingActivity.Date, cookingActivity.Id);
            }
            break;
        case 3:
            {
                Console.WriteLine("Enter FoodName");
                var name = Console.ReadLine();
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly dete = DateOnly.Parse(Console.ReadLine());
                var eatingActivity = new EatingFood(dete, start, end, name);
                eatingActivity.SetId();
                Activity.AddToList(eatingActivity);
                ToDoList.AddtoToDoList(eatingActivity.Date, eatingActivity.Id);
            }
            break;
        case 4:
            {
                Console.WriteLine("Enter description");
                var description = Console.ReadLine();
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly dete = DateOnly.Parse(Console.ReadLine());
                var programmingActivity = new Programming(dete, start, end, description);
                programmingActivity.SetId();
                Activity.AddToList(programmingActivity);
                ToDoList.AddtoToDoList(programmingActivity.Date, programmingActivity.Id);
            }
            break;
        case 5:
            {
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly dete = DateOnly.Parse(Console.ReadLine());
                var sleepingActivity = new Sleeping(dete, start, end);
                sleepingActivity.SetId();
                Activity.AddToList(sleepingActivity);
                ToDoList.AddtoToDoList(sleepingActivity.Date, sleepingActivity.Id);
            }
            break;
        case 6:
            {
                Console.WriteLine("Enter description");
                var description = Console.ReadLine();
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly dete = DateOnly.Parse(Console.ReadLine());
                var HangingOutActivity = new HangingOut(dete, start, end, description);
                HangingOutActivity.SetId();
                Activity.AddToList(HangingOutActivity);
                ToDoList.AddtoToDoList(HangingOutActivity.Date, HangingOutActivity.Id);
            }
            break;
        case 7:
            {
                Console.WriteLine("Enter BookName");
                var name = Console.ReadLine();
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly dete = DateOnly.Parse(Console.ReadLine());
                var readingActivity = new ReedingBook(dete, start, end, name);
                readingActivity.SetId();
                Activity.AddToList(readingActivity);
                ToDoList.AddtoToDoList(readingActivity.Date, readingActivity.Id);
            }
            break;
        case 8:
            {
                Console.WriteLine("Enter ActivityId");
                var activityId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter  StartTime");
                var start = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  EndTime");
                var end = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter  Date");
                DateOnly date = DateOnly.Parse(Console.ReadLine());
                var activity = Activity.activities.FirstOrDefault(a => a.Id == activityId);
                activity.EditActivity(date, start, end);

            }
            break;
        case 9:
            {
                Console.WriteLine("Enter ActivityId");
                var activityId = int.Parse(Console.ReadLine());
                var activity = Activity.activities.FirstOrDefault(a => a.Id == activityId);
                Activity.RemoveActivity(activity);
            }
            break;
        case 10:
            {
                Console.WriteLine("Enter  Date");
                DateOnly date = DateOnly.Parse(Console.ReadLine());
                foreach (var id in ToDoList.ToDoLists[date])
                {
                    var activity = Activity.activities.FirstOrDefault(a => a.Id == id);
                    activity.ShowDetails();
                }
            }
            break;
    }
}
    
