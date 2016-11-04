using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //try
            //{
            //    string personName;
            //    sbyte personAge;

            //    Console.WriteLine("Please enter person's name:");
            //    personName = Console.ReadLine();
            //    Console.WriteLine("Please enter person's age:");
            //    personAge = SByte.Parse(Console.ReadLine());

            //    Person person1 = new Person();
            //    Person person2 = new Person(personName);
            //    Person person3 = new Person(personName, personAge);

            //    Console.WriteLine(person1.name + " " + person1.age);
            //    Console.WriteLine(person2.name + " " + person2.age);
            //    Console.WriteLine(person3.name + " " + person3.age);
            //}
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Task 3

            //Console.WriteLine("Please enter person name and age separated by //. To stop entering write 'quit' ");

            //var endPoint = "quit";
            //var list = new List<Person>();

            //while (true)
            //{
            //    var userInput = Console.ReadLine();

            //    if (string.IsNullOrEmpty(userInput))
            //    {
            //        continue;
            //    }

            //    if (userInput == endPoint)
            //    {
            //        break;
            //    }
            //    var personArray = userInput.Split(new[] { "//" }, StringSplitOptions.None);
            //    sbyte age;

            //    if (sbyte.TryParse(personArray[1], out age) && age > 18)
            //    {
            //        list.Add(new Person(personArray[0], age));
            //    }

            //}

            //list = list.OrderBy(p => p.Name.Length).ToList();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            //task4

            Console.WriteLine("Please enter the number of cources");
            var courseNumberInput = int.Parse(Console.ReadLine());
            var academy = new Academy();

            Console.WriteLine("Please enter the course name, duration(hours per day) and capacity in the following format courseName//duration//capacity");
            
            for (int i = 0; i < courseNumberInput; i++)
            {
                var courseInfo = Console.ReadLine();
                var courseArray = courseInfo.Split(new[] { "//" }, StringSplitOptions.None);

                academy.AddCourse(courseArray[0], int.Parse(courseArray[1]), int.Parse(courseArray[2]));
            }

            Console.WriteLine("Please enter the number of students which will attend courses");
            var studentNumberInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the student's name and age in the following format name//age");
            for(int x = 0; x < studentNumberInput; x++)
            {
                var studentInfo = Console.ReadLine();
                var studentsArray = studentInfo.Split(new[] { "//" }, StringSplitOptions.None);

                academy.AddStudent(studentsArray[0], sbyte.Parse(studentsArray[1]));
                //foreach(Student o in academy.StudentsList)
                //{
                //    Console.WriteLine("student's Id in academy: " + o.StudentId);
                //}
                
            }

            Console.WriteLine("Please subscribe students to courses by following syntax: studentId courseId");

            var endPoint = "quit";

            while(true)
            {
                var userInput = Console.ReadLine();
                if(string.IsNullOrEmpty(userInput))
                {
                    continue;
                }

                if(userInput == endPoint)
                {
                    break;
                }

                var subscriptionArray = userInput.Split(new[] { " " }, StringSplitOptions.None);
                var studentId = int.Parse(subscriptionArray[0]);
                var courseId = int.Parse(subscriptionArray[1]);
                academy.Subscribe(courseId, studentId);
            }
            academy.Print();
        }
    }
}