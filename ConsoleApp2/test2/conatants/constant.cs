using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace constates.test2.conatants.ConsoleApp2
{
    class constant
    {
        private const decimal factor = 2.2m;
        public decimal Name(decimal weight)
        {
            return weight * factor;
        }
        public decimal Name2(decimal weight)
        {
            return weight / factor;
        }
        public static void Run()
        {
            var constant = new constant();
            Console.WriteLine(constant.Name(10) + " " + constant.Name2(10));
            decimal weight, height;
            while (true)
            {
                Console.WriteLine("enter weight");
                weight = decimal.Parse(Console.ReadLine());
                Console.WriteLine("enter height");
                height = decimal.Parse(Console.ReadLine());
                Console.WriteLine(constant.Name(weight) + " " + constant.Name2(height / weight));
                break;
            }
        }
    }
}
