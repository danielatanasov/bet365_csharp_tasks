using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks2
{
    public class Course
    {
        private static int _count = 0;
        public List<Student> _signedIn = new List<Student>();

        public Course(string name,  int duration , int capacity)
        {
            
            this.Capacity = capacity;
            this.Name = name;
            this.Duration = duration;
            this.Id = _count;
            _count++;
        }

        public int Capacity { get; set; }
       // public List<Student> Students { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Id { get; set; } 

        public void Add(Student student)
        {
            if(_count <= this.Capacity)
            {
                _signedIn.Add(student);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Remove(Student student)
        {
            _signedIn.Remove(student);
        }

        public bool CheckForExistance(string name)
        {
            return _signedIn.Any(x => x.name == name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
