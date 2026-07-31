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
            int b = (int)Convert.ToSByte(Console.ReadLine());
           for(int i = 0; i < b; i++)
            {
                Console.WriteLine(KG.KgTolbs(Convert.ToDouble(Console.ReadLine())));
            }
        }
    }
}
