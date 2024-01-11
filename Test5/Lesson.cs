namespace Test5
{
    public class Lesson
    {
        internal static List<Lesson> Lessons = new List<Lesson>();

        public Lesson(int unit, string name)
        {
            Unit = unit;
            Name = name;
        }

        public int Id { get; set; }
        public int Unit { get; set; }
        public string Name { get; set; }
        internal void SetId()
        {
            if (Lessons.Count > 0)
                Id = Lessons.Last().Id + 1;

            else Id = 1;
        }

        internal static void AddtoList(Lesson lesson)
        {
            Lessons.Add(lesson);
        }
    }
}