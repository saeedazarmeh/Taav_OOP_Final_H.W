namespace Test5
{
    public class TakedLesson
    {
        public TakedLesson(int lessonId)
        {
            LessonId = lessonId;
        }

        public decimal? Mark { get; set; }
        public int LessonId { get; set; }
    }
}