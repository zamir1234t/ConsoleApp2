using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mallenkiy.newFolder.newFolders.ConsoleApp2
{
    class small
    {
        class classic
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public byte age { get; set; }
            public string fullname => $"{FirstName} {LastName} {age}";

            public string invalid => $"{FirstName} {LastName} {age}";
        }

        class classic2: classic
        {
                       public string invalid2 => $"{LastName}{FirstName} {age}";
        }

        public static void Run()
        {
            var classices2 = new classic2
            {
                FirstName = "John",
                LastName = "Doe",
                age = 10
            };
            Console.WriteLine($"Full {classices2.fullname}");
        }
    }
}
