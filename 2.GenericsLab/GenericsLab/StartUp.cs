using System;

internal class StartUp
{
    private static void Main(string[] args)
    {
        Box<int> box = new Box<int>();
        box.Add(1);
        box.Add(2);
        box.Add(3);
        Console.WriteLine(box.Remove());
        box.Add(4);
        box.Add(5);
        Console.WriteLine(box.Remove());

        string[] strings = ArrayCreator.Create(5, "Pesho");
        int[] integers = ArrayCreator.Create(10, 33);
    }
}