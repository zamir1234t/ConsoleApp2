using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ferst.ConsoleApp2
{
   class Games
    {
        private Type[] member = new Type[10];

        //public string Names { get; set; }
        //public string LastName { get; set;}
        //public byte age { get; set; }
        //public Games(string names, string lastName, byte age)
        //{
        //    LastName = lastName;
        //    Names = names;
        //    this.age = age;
        //}
        //private double[,] data;

        //public Games(int row, int column)
        //{
        //    data = new double[row, column];
        //}

        //public double this[int row, int column]
        //{
        //    get => data[row, column];
        //    set => data[row, column] = value;
        //}

        //public string Name { get; init; } = string.Empty;
        //public sbyte age { get; init; } = 1;
        //static class lengthConvert
        //{
        //    public static double FeetToMeters(double ft) => ft / 3.29;
        //    public static double MetersToFeet(double m) => m * 3.29;
        //}
        //public Type this[int i]
        //{
        //    get => member[i];
        //    set => member[i] = value;
        //}
        //class Sentence
        //{
        //    private string[] word;
        //    public Sentence(string s)
        //    {
        //        word = s.Split(" ");
        //    }

        //    public string this[int i]
        //    {
        //        get
        //        {
        //            return word[i];
        //        }
        //    }
        //}

        public static void Run(string[] args)
        {
            //var Games = new Games("ali", "ali", 20);
            // Console.WriteLine(Games.Names + " " + Games.LastName + " " + Games.age);
            //var games = new Games(3, 3)
            //{
            //    [0, 0] = 1,
            //    [0, 1] = 2,
            //    [0, 2] = 3,
            //    [1, 0] = 4,
            //    [1, 1] = 5,
            //    [1, 2] = 6,
            //    [2, 0] = 7,
            //    [2, 1] = 8,
            //    [2, 2] = 9
            //};
            //for(int row = 0; row < 3; row++)
            //{
            //    for(int column = 0; column < 3; column++)
            //    {
            //        Console.Write($"{games[row, column]}");
            //    }
            //    Console.WriteLine();
            //}
            //var games = new Games()
            //{
            //    Name = "ali",
            //    age = 10
            //};
            //Console.WriteLine(games.Name + " " + games.age);
            //double ft, m = 0;
            //ft = 900;
            //m = lengthConvert.FeetToMeters(ft);
            //Console.WriteLine($"{ft}ft = {m:0.##}m");

            //m = 900;
            //ft = lengthConvert.FeetToMeters(m);
            //Console.WriteLine($"{m}m = {ft:0.##}ft");
            //var sentence = new Sentence("C# is awesome");
            //Console.WriteLine(sentence[0]);
        }
    }
}
