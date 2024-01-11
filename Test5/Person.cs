using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    internal class Person : IPersonRepository
    {
        internal static List<Person> persons = new List<Person>();

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public List<TakedLesson> TakedLessons { get; set; } = new List<TakedLesson>();


        internal void SetId()
        {
            if (persons.Count > 0)
                Id = persons.Last().Id + 1;

            else Id = 1;
        }
        public static void AddtoList(Person person)
        {
            persons.Add(person);
        }

        public virtual void AddMarkToLesson(int lessonId, decimal mark)
        {
            var lession = TakedLessons.FirstOrDefault(l => l.LessonId == lessonId);
            lession.Mark = mark;
        }
        public virtual void TakeLesssion(int lessonId)
        {
            TakedLessons.Add(new TakedLesson(lessonId));
        }

        public virtual void EditPeson(string name, int age)
        {
            throw new NotImplementedException();
        }

        public virtual void ShowDet()
        {
            throw new NotImplementedException();
        }
    }

    internal class Student : Person
    {
        public Student(string name, int age, int fieldId ,int studentId) : base(name, age)
        {
            FieldId = fieldId;
            StudentId = studentId;
        }

        public int StudentId { get; protected set; }
        public int FieldId { get; protected set; }

        public override void TakeLesssion(int lessonId)
        {
            TakedLessons.Add(new TakedLesson(lessonId));
        }
        public override void AddMarkToLesson(int lessonId, decimal mark)
        {
            var lession =TakedLessons.FirstOrDefault(l => l.LessonId == lessonId);
            lession.Mark = mark;
        }

        public override void EditPeson(string name, int age)
        {
            Name = Name;
            Age = age;
        }
        public override void ShowDet()
        {
            var field=FieldOfStudy.fields.FirstOrDefault(f => f.Id== FieldId);
            Console.WriteLine($"Id:{Id} Name:{Name} Age:{Age} Field:{field}");
            foreach (var Takedlesson in TakedLessons)
            {
                var lesson = Lesson.Lessons.FirstOrDefault(l => l.Id == Takedlesson.LessonId);
                Console.WriteLine($"Lesson:{lesson.Name} Unit:{lesson.Unit} Mark:{Takedlesson.Mark}");
            }
        }

    }


    internal class Professor : Person
    {
        public Professor(string name, int age, int fieldId) : base(name, age)
        {
            FieldId = fieldId;
        }

        public int FieldId { get; protected set; }

        public override void TakeLesssion(int lessonId)
        {
            TakedLessons.Add(new TakedLesson(lessonId));
        }
        public override void EditPeson(string name, int age)
        {
            Name = Name;
            Age = age;
        }
        public override void ShowDet()
        {
            var field = FieldOfStudy.fields.FirstOrDefault(f => f.Id == FieldId);
            Console.WriteLine($"Id:{Id} Name:{Name} Age:{Age} Field:{field}");
            foreach (var Takedlesson in TakedLessons)
            {
                var lesson = Lesson.Lessons.FirstOrDefault(l => l.Id == Takedlesson.LessonId);
                Console.WriteLine($"Lesson:{lesson.Name} Unit:{lesson.Unit}");
            }
        }

    }
}
