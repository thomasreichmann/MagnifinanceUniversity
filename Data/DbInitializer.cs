using MagnifinanceUniversity.Models;

namespace MagnifinanceUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var courses = new Course[]
{
            new Course{Name="TestCourse0"},
            new Course{Name="TestCourse1"},
            new Course{Name="TestCourse2"},
            new Course{Name="TestCourse3"},
            new Course{Name="TestCourse4"},
            new Course{Name="TestCourse5"},
            new Course{Name="TestCourse6"}
};
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var students = new Student[]
            {
            new Student{BirthDay=DateTime.Parse("2005-09-01"), Name="TestStudent1"},
            new Student{BirthDay=DateTime.Parse("2002-09-01"), Name="TestStudent2"},
            new Student{BirthDay=DateTime.Parse("2003-09-01"), Name="TestStudent3"},
            new Student{BirthDay=DateTime.Parse("2002-09-01"), Name="TestStudent4"},
            new Student{BirthDay=DateTime.Parse("2002-09-01"), Name="TestStudent5"},
            new Student{BirthDay=DateTime.Parse("2001-09-01"), Name="TestStudent6"},
            new Student{BirthDay=DateTime.Parse("2003-09-01"), Name="TestStudent7"},
            new Student{BirthDay=DateTime.Parse("2005-09-01"), Name="TestStudent8"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var teachers = new Teacher[]
{
            new Teacher{Name="testTeacher0", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher1", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher2", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher3", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher4", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher5", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher6", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher7", BirthDay=DateTime.Now, Salary=12.5},
            new Teacher{Name="testTeacher8", BirthDay=DateTime.Now, Salary=12.5}
};
            foreach (Teacher t in teachers)
            {
                context.Teachers.Add(t);
            }
            context.SaveChanges();

            var subjects = new Subject[]
            {
            new Subject{SubjectID=1050, CourseID=1,Title="Chemistry"},
            new Subject{SubjectID=4022, CourseID=1,Title="Microeconomics"},
            new Subject{SubjectID=4041, CourseID=1,Title="Macroeconomics"},
            new Subject{SubjectID=1045, CourseID=2,Title="Calculus"},
            new Subject{SubjectID=3141, CourseID=2,Title="Trigonometry"},
            new Subject{SubjectID=2021, CourseID=3,Title="Composition"},
            new Subject{SubjectID=2042, CourseID=3,Title="Literature"}
            };
            foreach (Subject c in subjects)
            {
                context.Subjects.Add(c);
            }
            context.SaveChanges();

            var assingments = new Assingment[]
{
            new Assingment{TeacherID=1,SubjectID=1050},
            new Assingment{TeacherID=1,SubjectID=4022},
            new Assingment{TeacherID=1,SubjectID=4041},
            new Assingment{TeacherID=1,SubjectID=1045},
            new Assingment{TeacherID=2,SubjectID=3141},
            new Assingment{TeacherID=2,SubjectID=2021},
            new Assingment{TeacherID=3,SubjectID=2042},
};
            foreach (Assingment a in assingments)
            {
                context.Assingments.Add(a);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,SubjectID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,SubjectID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,SubjectID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,SubjectID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,SubjectID=1050},
            new Enrollment{StudentID=4,SubjectID=1050},
            new Enrollment{StudentID=4,SubjectID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,SubjectID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,SubjectID=1045},
            new Enrollment{StudentID=7,SubjectID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
