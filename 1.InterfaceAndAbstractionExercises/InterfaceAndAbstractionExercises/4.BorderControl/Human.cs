namespace InterfaceAndAbstractionExercises._5.BorderControl
{
    public class Human : IIdentifiable
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Human(string id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}