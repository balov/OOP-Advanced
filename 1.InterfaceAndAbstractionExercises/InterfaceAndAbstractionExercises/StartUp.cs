using InterfaceAndAbstractionExercises._7.FoodShortage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceAndAbstractionExercises
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            //1. IPerson
            //Type personInterface = typeof(Citizen).GetInterface("IPerson");
            //PropertyInfo[] properties = personInterface.GetProperties();
            //Console.WriteLine(properties.Length);
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //IPerson person = new Citizen(name, age);
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);

            //2. Multiple Implementation
            //Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
            //Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
            //PropertyInfo[] properties = identifiableInterface.GetProperties();
            //Console.WriteLine(properties.Length);
            //Console.WriteLine(properties[0].PropertyType.Name);
            //properties = birthableInterface.GetProperties();
            //Console.WriteLine(properties.Length);
            //Console.WriteLine(properties[0].PropertyType.Name);
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //string id = Console.ReadLine();
            //string birthdate = Console.ReadLine();
            //IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            //IBirthable birthable = new Citizen(name, age, id, birthdate);

            //3. Ferrari
            //string ferrariName = typeof(Ferrari).Name;
            //string iCarInterfaceName = typeof(ICar).Name;
            //
            //bool isCreated = typeof(ICar).IsInterface;
            //if (!isCreated)
            //{
            //    throw new Exception("No interface ICar was created");
            //}
            //string driverName = Console.ReadLine();
            //ICar ferrari = new Ferrari("488-Spider", driverName);
            //Console.WriteLine($"{ferrari.Model}/{ferrari.Brake()}/{ferrari.PushTheGas()}/{ferrari.DriverName}");

            //4. Telephony
            //var numbers = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //var urls = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //
            //var smartPhone = new SmartPhone();
            //
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(smartPhone.Call(n));
            //}
            //
            //foreach (var url in urls)
            //{
            //    Console.WriteLine(smartPhone.Browse(url));
            //}

            //5. Border Control
            //string input;
            //
            //List<IIdentifiable> controlled = new List<IIdentifiable>();
            //
            //while ((input = Console.ReadLine()) != "End")
            //{
            //    var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //
            //    if (tokens.Count() == 2)
            //    {
            //        IIdentifiable robot = new Robot(tokens[1], tokens[0]);
            //        controlled.Add(robot);
            //    }
            //    else if (tokens.Count() == 3)
            //    {
            //        IIdentifiable human = new Human(tokens[2], tokens[0], int.Parse(tokens[1]));
            //        controlled.Add(human);
            //    }
            //}
            //
            //string fakeId = Console.ReadLine();
            //
            //foreach (var item in controlled)
            //{
            //    if (item.Id.EndsWith(fakeId))
            //    {
            //        Console.WriteLine(item.Id);
            //    }
            //}

            //6. Birthday Celebrations
            //string input;
            //
            //List<IBirthable> controlled = new List<IBirthable>();
            //
            //while ((input = Console.ReadLine()) != "End")
            //{
            //    var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //
            //    if (tokens[0] == "Pet")
            //    {
            //        IBirthable pet = new Pet(tokens[2], tokens[1]);
            //        controlled.Add(pet);
            //    }
            //    else if (tokens[0] == "Citizen")
            //    {
            //        IBirthable citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
            //        controlled.Add(citizen);
            //    }
            //}
            //
            //string birthDate = Console.ReadLine();
            //
            //foreach (var item in controlled)
            //{
            //    if (item.Birthdate.EndsWith(birthDate))
            //    {
            //        Console.WriteLine(item.Birthdate);
            //    }
            //}

            //7. Food Shortage

            int n = int.Parse(Console.ReadLine());

            string input = String.Empty;

            List<IPerson> persons = new List<IPerson>();

            List<string> buyerNames = new List<string>();

            while (input != "End")
            {
                for (int i = 0; i < n; i++)
                {
                    var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (tokens.Count() == 4)
                    {
                        IPerson citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                        persons.Add(citizen);
                    }
                    else if (tokens.Count() == 3)
                    {
                        IPerson rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        persons.Add(rebel);
                    }
                }

                input = Console.ReadLine();

                if (input != "End")
                {
                    buyerNames.Add(input);
                }
            }

            int counter = 0;

            foreach (var name in buyerNames)
            {
                if (persons.Any(p => p.Name == name))
                {
                    if (persons.Where(p => p.Name == name).FirstOrDefault() is Citizen)
                    {
                        counter += 10;
                    }
                    if (persons.Where(p => p.Name == name).FirstOrDefault() is Rebel)
                    {
                        counter += 5;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}