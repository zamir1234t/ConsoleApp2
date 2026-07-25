using System;

namespace ConsoleApp2
{
    class Car
    {
        private string? firstName;
        private string? lastName;

        public string GetFullName() => $"{firstName} {lastName}";

        private bool IsValidName(string? name)
        {
            return !string.IsNullOrEmpty(name);
        }

        public Car SetFirstName(string? firstName)
        {
            if (IsValidName(firstName))
            {
                this.firstName = firstName;
            }
            return this;
        }

        public Car SetLastName(string? lastName)
        {
            if (IsValidName(lastName))
            {
                this.lastName = lastName;
            }
            return this;
        }

        public static void Run(string[] args)
        {
            Console.WriteLine("Enter the first name and last name:");

            string? firstName = Console.ReadLine();
            string? lastName = Console.ReadLine();

            Car car = new Car()
                .SetFirstName(firstName)
                .SetLastName(lastName);

            Console.WriteLine("Hello, " + car.GetFullName());
        }
    }
}