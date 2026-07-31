using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.newFolder.newFolders.ConsoleApp2
{
    internal class eliment
    {
        
        public static void Run()
        {
            string[] v = "the first line".Split('\n');
            StringBuilder a = new();
            a.AppendLine("the first line");
            foreach( var i in v)
            {
                a.AppendLine(i);
            }
            Console.WriteLine(a);
        }
    }
}
