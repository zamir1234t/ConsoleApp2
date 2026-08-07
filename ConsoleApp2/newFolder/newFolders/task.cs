using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.newFolder.newFolders.ConsoleApp2
{
class task
    {
        class employt
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public byte age { get; set; }

            public string fullname => $"{FirstName} {LastName}";

            public string info => $"{fullname} is {age} years old";
            public employt(string firstName, string lastName, byte age)
            {
                FirstName = firstName;
                LastName = lastName;
                this.age = age;
            }

            class employee : employt
            {
                public string jobtitle { get; set; }
                public decimal salary { get; set; }

                public employee(string firstName, string lastName, byte age, string jobtitle, decimal salary) : base(firstName, lastName, age)
                {
                    this.jobtitle = jobtitle;
                    this.salary = salary;
                }
            }
        }
        public static void Run()
        {
         var e = new  employt("John", "Doe", 10);
            Console.WriteLine(e.info);
        }
    }
}
