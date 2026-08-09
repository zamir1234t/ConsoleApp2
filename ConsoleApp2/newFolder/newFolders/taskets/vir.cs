using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtyal.newFolder.newFolders.taskets.ConsoleApp2
{
class vir
    {
        //1 сектор
        // -----------------------------------------------------------------------
        //class Person
        //{
        //    public string Name { get; set; }

        //    public  string Introduce() => $"Hi, I'm {Name}.";
        //}

        //class emloyd : Person
        //{
        //    public string JobTitle { get; set; }

        //    public   string Introduce() => $"Hi, I'm {Name}. I'm a {JobTitle}.";
        //}

        class Myclass
        {
            public virtual string Nmae { get; set; }

            public virtual void Method() { }
        }

        class Myclass2 : Myclass
        {
            public sealed override string Nmae { get; set; }

            public sealed override void Method() { }
        }
        public static void Run()
        {
            //1 сектор
            //var employee = new emloyd { Name = "John", JobTitle = "Manager" };
            //Console.WriteLine(employee.Introduce());
            //Person person = employee;
            //Console.WriteLine(person.Introduce());
            //-----------------------------------------------------------------------

            var myclass = new Myclass2();
            myclass.Method();
            Console.WriteLine(myclass.Nmae);
        }
    }
}
