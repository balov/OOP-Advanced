namespace InterfaceAndAbstractionExercises._7.FoodShortage
{
    public class Rebel : IPerson, IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }

        public string Group { get; set; }

        public Rebel(string name, int age, string @group)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
            this.Group = @group;
        }

        public void BayFood()
        {
            this.Food += 5;
        }
    }
}