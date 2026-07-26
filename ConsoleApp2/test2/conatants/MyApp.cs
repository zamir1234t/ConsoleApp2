using System;
using System.Globalization;
using static System.Math;

namespace two.Services
{
    class MyApp
    {
        public string Greate(string name)
        {
            var culture = CultureInfo.CurrentCulture;
            return $"hello {name}";
        }
        public static void Run(string[] args)
        {
            var myapp = new MyApp();
            Console.WriteLine(myapp.Greate("coco"));
        }
    }
}
