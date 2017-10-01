namespace InterfaceAndAbstractionExercises._3.Ferrari
{
    public class Ferrari : ICar
    {
        public string Model { get; set; }
        public string DriverName { get; set; }

        public Ferrari(string model, string driverName)
        {
            this.Model = model;
            this.DriverName = driverName;
        }

        public string Brake()
        {
            return "Brakes!";
        }

        public string PushTheGas()
        {
            return "Zadu6avam sA!";
        }
    }
}