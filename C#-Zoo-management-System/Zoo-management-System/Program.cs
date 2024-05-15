using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Zoo_management_System
{
    // Interface definitions
    interface IFeedable
    {
        void Feed(Food food);
    }

    public interface IClimbable
    {
        void Climb();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public interface IFlyable
    {
        void Fly();
    }

    interface IMovable
    {
        void Move();
    }

    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile,
        Fish
    }

    public enum FoodType
    {
        Meat,
        Vegetation,
        Mixed,
        Fruits,
        Seeds,
        Vegetables,
    }

    public enum HabitatType
    {
        Desert,
        Forest,
        Aquatic
    }

    public enum FoodTypeEnum
    {
        Meat,
        Fruits,
        Vegetables,
        Seeds
    }

    public class DietInfo
    {
        public FoodType FoodType { get; }
        public string FeedingSchedule { get; }

        public DietInfo(FoodType foodType, string feedingSchedule)
        {
            FoodType = foodType;
            FeedingSchedule = feedingSchedule;
        }
    }

    [Serializable]
    public class Food
    {
        public FoodTypeEnum FoodType { get; set; }

        public override string ToString()
        {
            return FoodType.ToString();
        }
    }

    // Base class
    [Serializable]
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public AnimalType AnimalType { get; set; }
        public DietInfo DietInfo { get; set; }
        public HabitatType Habitat { get; set; }
        public string SpeakSound { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public virtual void WakeUp()
        {
            Console.WriteLine($"{Name} is waking up.");
        }

        public virtual void Jump()
        {
            Console.WriteLine($"{Name} is jumping.");
        }

        public abstract void Speak();
    }

    [Serializable]
    public class Lion : Animal, IFeedable, IMovable
    {
        public Lion()
        {
            AnimalType = AnimalType.Mammal;
            DietInfo = new DietInfo(FoodType.Meat, "Twice a day");
        }

        public override void Speak()
        {
            SpeakSound = "Roar!";
            Console.WriteLine(SpeakSound);
        }

        public void Feed(Food food)
        {
            Console.WriteLine($"Feeding {Name} with {food}.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is moving around the den.");
        }
    }

    [Serializable]
    public class Parrot : Animal, IFeedable, IMovable, IFlyable
    {
        public Parrot()
        {
            AnimalType = AnimalType.Bird;
            DietInfo = new DietInfo(FoodType.Seeds, "Thrice a day");
        }

        public override void Speak()
        {
            SpeakSound = "Squawk!";
            Console.WriteLine(SpeakSound);
        }

        public void Feed(Food food)
        {
            Console.WriteLine($"Feeding {Name} with {food}.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is moving around.");
        }
    }

    [Serializable]
    public class Monkey : Animal, IFeedable, IMovable, IClimbable
    {
        public Monkey()
        {
            AnimalType = AnimalType.Mammal;
            DietInfo = new DietInfo(FoodType.Fruits, "Twice a day");
        }

        public override void Speak()
        {
            SpeakSound = "Ooh! Ooh! Aah! Aah!";
            Console.WriteLine(SpeakSound);
        }

        public void Feed(Food food)
        {
            Console.WriteLine($"Feeding {Name} with {food}.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is moving around the habitat.");
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing.");
        }
    }

    [Serializable]
    public class Gorilla : Animal, IFeedable, IMovable, IClimbable
    {
        public Gorilla()
        {
            AnimalType = AnimalType.Mammal;
            DietInfo = new DietInfo(FoodType.Fruits, "Twice a day");
        }

        public override void Speak()
        {
            SpeakSound = "Grunt! Grunt!";
            Console.WriteLine(SpeakSound);
        }

        public void Feed(Food food)
        {
            Console.WriteLine($"Feeding {Name} with {food}.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is moving around the sanctuary.");
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing.");
        }
    }

    [Serializable]
    public class Fish : Animal, ISwimmable
    {
        public Fish()
        {
            AnimalType = AnimalType.Fish;
            DietInfo = new DietInfo(FoodType.Vegetables, "Once a day");
        }

        public override void Speak()
        {
            SpeakSound = "Blub Blub!";
            Console.WriteLine(SpeakSound);
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }
    }

    // Zoo management class
    class ZooManager
    {
        private const string FilePath = "animals.json";
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            SaveAnimals();
            Console.WriteLine($"{animal.Name} has been added to the zoo.");
        }

        public ZooManager()
        {
            LoadAnimals();
        }
        public void ViewAnimals()
        {
            Console.WriteLine("Animals in the zoo:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} ({animal.GetType().Name})");
            }
        }
        public void RemoveAnimal(string name)
        {
            var animal = animals.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (animal != null)
            {
                animals.Remove(animal);
                SaveAnimals();
                Console.WriteLine($"{animal.Name} has been removed from the zoo.");
            }
            else
            {
                Console.WriteLine($"Animal with name '{name}' not found in the zoo.");
            }
        }

        public void LocateAnimal(string name)
        {
            var animal = animals.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (animal != null)
            {
                Console.WriteLine($"{animal.Name} is located in the {GetAnimalLocation(animal)}.");
            }
            else
            {
                Console.WriteLine($"Animal with name '{name}' not found in the zoo.");
            }
        }

        public string GetAnimalInteractions()
        {
            string interactions = "";
            foreach (var animal in animals)
            {
                interactions += $"{animal.Name} says: ";
                animal.Speak();
                interactions += $"{animal.Name} is being fed: ";
                if (animal is IFeedable feedable)
                {
                    feedable.Feed(GetFoodForAnimal(animal));
                }
                interactions += $"{animal.Name} is moving: ";
                if (animal is IMovable movable)
                {
                    movable.Move();
                }

                // Handle cross-category capabilities
                if (animal is IClimbable climbable)
                {
                    climbable.Climb();
                }
                if (animal is ISwimmable swimmable)
                {
                    swimmable.Swim();
                }
                if (animal is IFlyable flyable)
                {
                    flyable.Fly();
                }

                interactions += "\n";
            }
            return interactions;
        }

        public void WatchAnimalsInteract()
        {
            Console.WriteLine("Watching animals interact:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} is interacting:");

                animal.Speak();

                if (animal is IFeedable feedable)
                {
                    Food food = GetFoodForAnimal(animal);
                    feedable.Feed(food);
                    Console.WriteLine($"{animal.Name} is eating {food}.");
                }

                if (animal is IMovable movable)
                {
                    movable.Move();
                }

                // Handle cross-category capabilities
                if (animal is IClimbable climbable)
                {
                    climbable.Climb();
                }
                if (animal is ISwimmable swimmable)
                {
                    swimmable.Swim();
                }
                if (animal is IFlyable flyable)
                {
                    flyable.Fly();
                }

                Console.WriteLine("");
            }
        }

        private string GetAnimalLocation(Animal animal)
        {
            if (animal is Lion)
            {
                return "Carnivores land";
            }
            else if (animal is Parrot)
            {
                return "aviary";
            }
            else if (animal is Monkey)
            {
                return "Omnivorous lands of everything ";
            }
            else if (animal is Gorilla)
            {
                return "Herbivore big leaves ";
            }
            else if (animal is Fish)
            {
                return "Aquarium";
            }
            else
            {
                return "unknown location";
            }
        }

        private Food GetFoodForAnimal(Animal animal)
        {
            if (animal is Lion)
            {
                return new Food { FoodType = FoodTypeEnum.Meat };
            }
            else if (animal is Parrot)
            {
                return new Food { FoodType = FoodTypeEnum.Seeds };
            }
            else if (animal is Monkey || animal is Gorilla)
            {
                return new Food { FoodType = FoodTypeEnum.Fruits };
            }
            else
            {
                return new Food { FoodType = FoodTypeEnum.Vegetables };
            }
        }

        // Add this method to get an animal by its name
        public Animal GetAnimalByName(string name)
        {
            // Use the Find method to locate the animal by name
            return animals.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Update the method signature to match the internal keyword in AnimalsView.cs
        internal IEnumerable<Animal> GetAnimals()
        {
            return animals;
        }

        public void SaveAnimals()
        {
            string json = JsonConvert.SerializeObject(animals, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText(FilePath, json);
        }

        public void LoadAnimals()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                animals = JsonConvert.DeserializeObject<List<Animal>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                }) ?? new List<Animal>();
            }
        }


    }


    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
