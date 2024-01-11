using Test5;

while (true)
{
    Console.WriteLine("Choose your Operation Index:\n" +
     "1-Add Field\n" +
     "2-Add Lesson\n" +
     "3-Add Student\n" +
     "4-Add Professor \n" +
     "5-Add Lesson \n" +
     "6-Edit Person\n \n" +
     "7-Set Mark\n" +
     "8-Show Person Det\n");
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter name");
                var name = Console.ReadLine();
                var field = new FieldOfStudy(name);
                field.SetId();
                FieldOfStudy.AddtoList(field);
            }
            break;
        case 2:
            {
                Console.WriteLine("Enter name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter unit");
                var unit = int.Parse(Console.ReadLine());
                var lesson = new Lesson(unit, name);
                lesson.SetId();
                Lesson.AddtoList(lesson);
            }
            break;
        case 3:
            {
                Console.WriteLine("Enter name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Age");
                var age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter studentId");
                var studentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter FieldId");
                var fieldId = int.Parse(Console.ReadLine());
                var student = new Student(name,age,fieldId,studentId);
                student.SetId();
                Person.AddtoList(student);
            }
            break;
        case 4:
            {
                Console.WriteLine("Enter name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Age");
                var age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter FieldId");
                var fieldId = int.Parse(Console.ReadLine());
                var professor = new Professor(name, age, fieldId);
                professor.SetId();
                Person.AddtoList(professor);
            }
            break;
        case 5:
            {
                Console.WriteLine("Enter PesonId");
                var personId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter LessonId");
                var lessonId = int.Parse(Console.ReadLine());
                var person = Person.persons.FirstOrDefault(p=>p.Id==personId);
                person.TakeLesssion(lessonId);
            }
            break;
        case 6:
            {
                Console.WriteLine("Enter PesonId");
                var personId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Age");
                var age = int.Parse(Console.ReadLine());
                var person = Person.persons.FirstOrDefault(p => p.Id == personId);
                person.EditPeson(name,age);
            }
            break;
        case 7:
            {
                Console.WriteLine("Enter PesonId");
                var personId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter LessonId");
                var lessonId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter mark");
                var mark = decimal.Parse(Console.ReadLine());
                var person = Person.persons.FirstOrDefault(p => p.Id == personId);
                person.AddMarkToLesson(lessonId,mark);
            }
            break;
        case 8:
            {
                Console.WriteLine("Enter PesonId");
                var personId = int.Parse(Console.ReadLine());
                var person = Person.persons.FirstOrDefault(p => p.Id == personId);
                person.ShowDet();
            }
            break;
    }
}
