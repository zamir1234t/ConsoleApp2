using System;


namespace ConsoleApp2
{
    class File
    {
      
        public static void Run(string[] args)
        {
            //if else синтаксис

            //int a = 5;
            //int b = 10;
            //if (a < b && a != b)
            //{
            //  Console.WriteLine("true");

            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //int num = 10;
            //string result = num % 3 == 0 ? "четное" : "нечетное";
            //Console.WriteLine(result);

            //while синтаксис

            // int num = 0;
            //while (num < 7)
            // {
            //     num++;
            //     Console.WriteLine(num);

            // }
            //for синтаксис
            // добавляем <= чтобы чисило было ровно до 6
            //for (int i = 1; i <= 6; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach синтаксис
            //string[] car = { "volvo", "bmv", "mercedes" };
            //foreach(string i in car)
            //{
            //    Console.WriteLine(i);
            //}
            // тут воид метод
            //void sayHI()
            //   {
            //       Console.WriteLine("your name");
            //       string names = Console.ReadLine();
            //       Console.WriteLine("your name: " + names);
            //   }
            //   sayHI();

            //string sayHI(string name)
            //{
            //    return $"hi {name}";
            //}
            //string name = sayHI("joins");
            //Console.WriteLine(name);

            //double CalculateBMI(double weight, double height)
            //{
            //    return weight / height * weight;
            //}
            //double m = CalculateBMI(70, 1.75);
            //Console.WriteLine(m);

            // <------------ Параметры дефолта ------------>
            //double cal(double nam1, double nam2=0.08)
            //{
            //    return nam1 * (1 + nam2);
            //}
            //var spalace = cal(100);
            //Console.WriteLine(spalace);
            // это array массив чисел
            //int[] name = {1,2,3,4,5,6,7,8,9,};
            //for (int i = 0; i < name.Length; i++)
            //{
            //    while(name [i] % 2 == 0)
            //    {
            //        Console.WriteLine(name [i]);
            //        break;
            //    }
            //}
            //int[] name = { 1, 2, 3, 4, 5, };
            //for (int i = 0; i < name.Length; i++) { 
            //    Console.WriteLine(name[i]);
            //}

            //Многомерные массивы
            //int[,,] data = new int[1, 2, 3];
            //Console.WriteLine(data[1,6,0]);
            //Console.ReadKey();
            //int[,] num = new int[2, 8]
            //{
            //    {1, 2,1,3,4,5,6,7 },
            //    { 3, 4,3,1,3,4,5,7 },
            //};
            //Console.WriteLine(num[1,0]);
            //Console.WriteLine(num[1, 6]);

            //int[,] matrix = new int[3, 3];
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrix[i, j] = i +j;
            //    }
            //}

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //        Console.Write(j < matrix.GetLength(1) - 1 ? "," : "");
            //    }
            //    Console.WriteLine();
            //}
            //---------------------------------

            //C# foreach----------------------------
            //int[,,] nam = new int[2, 2, 3]
            //{
            //    {{1,2,3}, {4,5,6}},
            //    {{7,8,9}, {10,11,12}}
            //};
            //foreach(int socar in nam)
            //{
            //    Console.Write(socar.CompareTo(1));
            //}

            //int[] score = { 1, 2, 3, 4 };

            //for(int i = 0; i < score.Length; i++)
            //{
            //    score[i] *= 2;
            //    Console.Write(score[i]);
            //}

            //int[] score = { 1, 2, 3, 4, };
            //foreach(int local in score)
            //{
            //    score[local] *= 2;// такой способ не работает; работает только с for 
            //    Console.Write(local);
            //}
        }
    }
}