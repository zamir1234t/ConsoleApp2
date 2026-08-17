using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameTypes.newFolder.newFolders.taskets.ConsoleApp2
{
class types
    {
       struct optionens
        {
            public double X { get; set; }
            public double Y { get; set; }

            public readonly double distance(Point other)
            {
                var dx = X - other.X;
                var dy = Y - other.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
            public override  string  ToString() => $"{X}, {Y}";
        }
        public static void Run()
        {
            var opm = new  optionens { X = 1.391, Y = 2.123 };
            var p1 = opm;
            p1.X = 2.121;
            Console.WriteLine(p1);
            Console.WriteLine(p1.X);
        }
    }
}
