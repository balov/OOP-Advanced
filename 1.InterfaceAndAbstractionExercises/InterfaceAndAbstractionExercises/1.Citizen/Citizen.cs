using InterfaceAndAbstractionExercises._7.FoodShortage;

namespace InterfaceAndAbstractionExercises
{
    public class Citizen : IPerson, IBirthable, IIdentifiable, IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
            this.Id = id;
            this.Food = 0;
        }

        public void BayFood()
        {
            this.Food += 10;
        }
    }
}