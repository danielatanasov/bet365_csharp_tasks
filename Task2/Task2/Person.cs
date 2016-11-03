using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Person
    {
        public string name;
        public sbyte age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public sbyte Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than 0");
                }
                age = value;
            }
        }

        public Person()
        {
            this.name = "No Name";
            this.age = 1;
        }

        public Person(string name) : this()
        {
            this.name = name;
        }

        public Person(string name, sbyte age) : this(name)
        {
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{ name} {age} ";
        }
    }
}