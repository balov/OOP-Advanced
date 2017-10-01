using System;

namespace Tuple
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            //1. Tuple
            //var input1 = Console.ReadLine().Split(' ');
            //Tuple<string, string> tuple1 = new Tuple<string, string>(input1[0] + " " + input1[1], input1[2]);
            //
            //var input2 = Console.ReadLine().Split(' ');
            //Tuple<string, int> tuple2 = new Tuple<string, int>(input2[0], int.Parse(input2[1]));
            //
            //var input3 = Console.ReadLine().Split(' ');
            //Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));
            //
            //tuple1.Print();
            //tuple2.Print();
            //tuple3.Print();

            //2. Treeple

            var input1 = Console.ReadLine().Split(' ');
            Threeuple<string, string, string> threpple1 = new Threeuple<string, string, string>(input1[0] + " " + input1[1], input1[2], input1[3]);

            var input2 = Console.ReadLine().Split(' ');
            bool drunkOrNot;
            if (input2[2] == "drunk")
            {
                drunkOrNot = true;
            }
            else
            {
                drunkOrNot = false;
            }
            Threeuple<string, int, bool> threpple2 = new Threeuple<string, int, bool>(input2[0], int.Parse(input2[1]), drunkOrNot);

            var input3 = Console.ReadLine().Split(' ');
            Threeuple<string, double, string> threpple3 = new Threeuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);

            threpple1.Print();
            threpple2.Print();
            threpple3.Print();
        }
    }
}