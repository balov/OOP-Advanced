namespace InterfaceAndAbstractionExercises._6.Birthday_Celebrations
{
    public class Pet : IBirthable
    {
        public string Birthdate { get; set; }

        public string Name { get; set; }

        public Pet(string birthdate, string name)
        {
            this.Birthdate = birthdate;
            this.Name = name;
        }
    }
}