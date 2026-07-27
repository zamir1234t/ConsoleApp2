using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondes.ConsoleApp2
{
 internal class sec
    {
        // угадай число 
        public static void Run(string[] args)
        {
            var rand = new Random();
            int a = rand.Next(1, 101);

            int attemt = 0;

            Console.WriteLine("введите число от 1 до 100");
            while (true)
            {
                Console.WriteLine("введите число от 1 до 100");
                string? input = Console.ReadLine();

                if(!int.TryParse(input, out int attemts))
                {
                    Console.WriteLine("это не то число");
                    continue;
                }
                attemt++;

                if (attemts > a)
                {
                    Console.WriteLine("меньше");
                }
                else if (attemts < a)
                {
                    Console.WriteLine("больше");
                }

                else
                {
                    Console.WriteLine($"вы попали {attemt}");
                    break;
                }
            }
        }
    }
}
