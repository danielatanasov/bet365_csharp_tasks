using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
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

            Console.WriteLine("Please enter person name and age separated by space. To stop entering write 'quit' ");

            var endPoint = "quit";
            var list = new List<Person>();

            while (true)
            {
                var userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    continue;
                }

                if (userInput == endPoint)
                {
                    break;
                }
                var personArray = userInput.Split(new[] { "//" }, StringSplitOptions.None);
                sbyte age;

                if (sbyte.TryParse(personArray[1], out age) && age > 18)
                {
                    list.Add(new Person(personArray[0], age));
                }

            }

            list = list.OrderBy(p => p.Name.Length).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}