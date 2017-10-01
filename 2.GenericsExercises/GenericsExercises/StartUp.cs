using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxExercise
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            //6. Generics Count Method String
            //int n = int.Parse(Console.ReadLine());
            //
            //List<Box<string>> listOfBoxes = new List<Box<string>>();
            //
            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    Box<string> box = new Box<string>(input);
            //    listOfBoxes.Add(box);
            //}
            //
            //var element = Console.ReadLine();
            //
            //Console.WriteLine(GetGreaterElementCount(listOfBoxes, element));
            //

            //7.Generic Count Method Doubles

            int n = int.Parse(Console.ReadLine());

            List<Box<double>> listOfBoxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(input);
                listOfBoxes.Add(box);
            }

            var element = double.Parse(Console.ReadLine());

            Console.WriteLine(GetGreaterElementCount(listOfBoxes, element));
        }

        private static void SwapElements<T>(IList<T> listOfBoxes, int i1, int i2)
        {
            T element = listOfBoxes[i1];
            listOfBoxes[i1] = listOfBoxes[i2];
            listOfBoxes[i2] = element;
        }

        public static int GetGreaterElementCount<T>(List<Box<T>> listOfBoxes, T element)
            where T : IComparable<T>
        {
            int result = listOfBoxes.Count(b => b.Value.CompareTo(element) > 0);
            return result;
        }
    }
}