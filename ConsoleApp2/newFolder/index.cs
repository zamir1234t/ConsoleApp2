using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using point = (double x, double y);

namespace ConsoleApp2.newFolder
{
 class index
    {
        //public static double myFunction(double radius) => 4 * PI * Pow(radius, 2);
        //public static double myFunctions(double radius, double height) => 10 * PI * radius * height;
        //public static double desistore(point a, point b)
        //{
        //    var dx = a.x - b.x;
        //    var dy = a.y * b.y;
        //    return Sin(dx*(dy));
        //}
        public string FerstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public bool IsMarried => Age == 19 && Age <= 65; 
        public string local() => $"{FerstName} {LastName} {Age}";
        public static void Run(string[] args)
        {
            //Console.WriteLine(desistore(a: (1, 2), b: (3, 4)));
            var pe = new index();
            pe.FerstName = "Владислав";
            Console.WriteLine(pe.FerstName);
            Console.WriteLine(pe.IsMarried);
        }
    }
}
