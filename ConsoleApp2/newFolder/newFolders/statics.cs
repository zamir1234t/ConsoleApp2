using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoris.newFolder.newFolders.ConsoleApp2
{
class statics
    {
       class KG
        {
            public static double KgTolbs(double kg) => kg * 2.2046;
            public static double LbsToKg(double lbs) => lbs / 2.2046;
        }
        public static void Run()
        {
            Console.WriteLine("Enter the weight in kilograms: ");
           double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Weight in kilograms: {KG.KgTolbs(b)}");
            Console.WriteLine($"Weight in pounds: {KG.LbsToKg(b)}");
        }
    }
}
