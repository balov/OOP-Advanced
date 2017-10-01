public class Tesla : ICar, IElectricCar
{
    public int Battery { get; }

    public string Color { get; }

    public string Model { get; }

    public Tesla(int battery, string color, string model)
    {
        this.Battery = battery;
        this.Color = color;
        this.Model = model;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}