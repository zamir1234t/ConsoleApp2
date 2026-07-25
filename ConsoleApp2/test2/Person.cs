//using System;
//using System.Drawing;


//namespace ConsoleApp2
//{
//    class Person
//    {
//        //public string FirstName;
//        //public string LastName;
//        //public string Age;
//        public string FirstName = Console.ReadLine();
//        public string LastName = Console.ReadLine();
//        public string GetFullName() => $"{FirstName} {LastName}";
//        //public string SayHi() => $"Привет, {GetFullName()}";
//        public Person SetFirstName(string FirstName)
//        {
//            this.FirstName = FirstName;
//            return this;
//        }
//        public Person SetLastName(string LastName)
//        {
//            this.LastName = LastName;
//            return this;
//        }

//        public static void Run(string[] args)
//        {
//            //var p1 = new Person();
//            //p1.Setname("Вася").SetlastName("Пупкин");
//            //Console.WriteLine(p1.SayHi());
//            //Car car = new Car();
//            //Console.WriteLine(car.color);
//            Person p1 = new Person();

//            //string greating = p1.SetFirstName("Вася")
//            //    .SetLastName("Пупкин")
//            //    .SayHi();
//            //Console.WriteLine(greating);
//            if (!string.IsNullOrEmpty(p1.FirstName))
//            {
//                p1.FirstName = p1.FirstName.Trim();
//            }
//            Console.WriteLine($"Привет, {p1.GetFullName()}");
//        }
//    }
//}
