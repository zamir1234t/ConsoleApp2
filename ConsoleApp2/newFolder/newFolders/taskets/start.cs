using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staets.newFolder.newFolders.taskets.ConsoleApp2
{
  class Start
    {
        class Person
        {
            public string Name { get; set; }

            public string Introduce() => $"Hi, I'm {Name}.";
        }

        class Employee : Person
        {
            public string JobTitle { get; set; }

            public new string Introduce() => $"Hi, I'm {Name}. I'm a {JobTitle}.";
        }
        public static void Run()
        {
            var employee = new Employee { Name = "John", JobTitle = "Manager" };
            Console.WriteLine(employee.Introduce());
        }
    }
}
