using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks2
{
    public class Academy
    {
        public List<Student> StudentsList { get; set; }
        public List<Course> CoursesList { get; set; }


        public Academy()
        {
            StudentsList = new List<Student>();
            CoursesList = new List<Course>();
        }

        public void AddCourse(string name, int duration, int capacity)
        {
            var course = new Course(name, duration, capacity);
            CoursesList.Add(course);
        }

        public void AddStudent(string name , sbyte age)
        {
            var student = new Student(name, age);
            StudentsList.Add(student);
        }

        public void Subscribe(int courseId, int studentId)
        {
            var student = StudentsList.Find(s => s.StudentId == studentId);
            if (student == null)
            {
                throw new Exception();
            }
            var course = CoursesList.Find(c => c.Id == courseId);
            if (course == null)
            {
                throw new Exception();
            }
            student.Course = course;
        }

        public void Print()
        {

            CoursesList.OrderBy(c => c.Name).ToList().ForEach(c =>
                {
                    Console.WriteLine(c.ToString());
                    StudentsList
                        .Where(s => s.Course.Id == c.Id)
                        .OrderBy(s => s.Age)
                        .ToList()
                        .ForEach(s => Console.WriteLine(s.Name));
                }
            );
        }
    }
}
