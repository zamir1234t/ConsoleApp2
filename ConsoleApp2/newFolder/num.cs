using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mumes.ConsoleApp2;

class num
{
    public static void Run(string[] args)
    {
        // сумма цифр числа 
        int sum = 0;
        int count = 0;
        Console.WriteLine("введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a == 0)
        {
            sum = 0;
            count = 1;
        }
        else
        {
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
                count++;
            }
        }
        Console.WriteLine($"сумма числа {sum} и количества цифр {count}");
    }
}


