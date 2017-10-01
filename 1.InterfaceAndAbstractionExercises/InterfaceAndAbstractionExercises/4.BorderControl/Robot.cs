namespace InterfaceAndAbstractionExercises._5.BorderControl
{
    public class Robot : IIdentifiable
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Robot(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}