using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folders.ConsoleApp2
{
    class testing
    {
        public interface IPtest
        {
            bool process(decimal amout);
        }

        public class creater : IPtest
        {
            public bool process(decimal amout)
            {
                Console.WriteLine(amout);
                return true;
            }

            public record pay(bool seccess, string? message);
        }
        public static void Run(string[] args)
        {
            var p = new creater();
            p.process(10);
        }
    }
}
