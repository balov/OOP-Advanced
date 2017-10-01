using System;

internal class StartUp
{
    private static void Main(string[] args)
    {
        ICar seat = new Seat("Leon", "Grey");
        ICar tesla = new Tesla(3, "Red", "Model 3");

        Console.WriteLine(seat.ToString());
        Console.WriteLine(tesla.ToString());
    }
}