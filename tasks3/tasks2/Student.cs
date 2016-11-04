using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks2
{
    public class Student : Person
    {
        private static int _count = 0;
        private Course course;

        public Course Course
        {
            get
            {
                return course;
            }
            set
            {
                if( course != null && value != null)
                {
                    throw new Exception("The student is already signed in a course");
                }
                course = value;
            }
        }

        public Student() : base()
        {
            StudentId = _count;
            IterrateCounter();
        }

        public Student(string name) : base(name)
        {
            StudentId = _count;
            IterrateCounter();
        }

        public Student(string name , sbyte age) : base(name, age)
        {
            StudentId = _count;
            IterrateCounter();
        }

        public int StudentId { get; private set; }

        private void IterrateCounter()
        {
            _count++;
        }

        
    }
}
