using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dol.newFolder.newFolders.taskets.ConsoleApp2
{
 class doubles
    {
        readonly struct temperature
        {
            public double Celsius { get; }

            public temperature(double celsius) => Celsius = celsius;

            public double Fahrenheit => Celsius * 1.8 + 32;

            public override string ToString()
            {
                return $"{Celsius:F1}C {Fahrenheit:F1}F";
            }
        }
        public static void Run()
        {
            var temp = new temperature(20);
            Console.WriteLine(temp);
        }
    }
}
