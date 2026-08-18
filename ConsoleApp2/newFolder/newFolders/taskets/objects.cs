using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectes.newFolder.newFolders.taskets.ConsoleApp2
{
class objects
    {

        class person
        {
            public string Ssn { get; set; }

            public string Name { get; set; }

            public byte Age { get; set; }


            public override string ToString()
            {
                return $"Name: {Name}, SSN: {Ssn}, Age: {Age}";
            }

            public override bool Equals(object? obj)
            {
                if(obj == null || GetType().Equals(obj.GetType()))
                {
                    return false;
                }

                var other = (person)obj;
                return other.Ssn == Ssn;
            }
        }
        public static void Run()
        {
           var p1 = new person { Ssn = "123-45-6789", Name = "John Doe", Age = 30 };
            var p2 = new person { Ssn = "123-45-6789", Name = "John Doe", Age = 30 };
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
