using System;

namespace Custom_List
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            string inputLine;

            CustomList<string> myCustomList = new CustomList<string>();

            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split(' ');

                switch (tokens[0])
                {
                    case "Add":
                        myCustomList.Add(tokens[1]);
                        break;

                    case "Remove":
                        myCustomList.Remove(int.Parse(tokens[1]));
                        break;

                    case "Contains":
                        Console.WriteLine(myCustomList.Contains(tokens[1]));
                        break;

                    case "Swap":
                        myCustomList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;

                    case "Greater":
                        Console.WriteLine(myCustomList.CountGreaterThan(tokens[1]));
                        break;

                    case "Max":
                        Console.WriteLine(myCustomList.Max());
                        break;

                    case "Min":
                        Console.WriteLine(myCustomList.Min());
                        break;

                    case "Print":
                        myCustomList.Print();
                        break;

                    case "Sort":
                        myCustomList = CostomListSorter.Sort(myCustomList);
                        break;
                }
            }
        }
    }
}