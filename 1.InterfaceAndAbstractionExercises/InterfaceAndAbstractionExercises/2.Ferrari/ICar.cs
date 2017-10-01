namespace InterfaceAndAbstractionExercises._3.Ferrari
{
    public interface ICar
    {
        string Model { get; }

        string DriverName { get; }

        string Brake();

        string PushTheGas();
    }
}