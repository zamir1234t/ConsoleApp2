using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commands.newFolder.newFolders.ConsoleApp2
{
 class Getcommand
    {
        class randomNumber
        {
            private static Random random;

            static randomNumber()
            {
                random = new Random();
            }
            public int get => random.Next();
        }
        public static void Run()
        {
            randomNumber random = new();
           while (true)
            {
               Console.WriteLine( random.get);
            }
        }
    }
}
