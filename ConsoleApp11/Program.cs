public interface IAnimal
{
    void MakeSound();
    string GetInfo();
}

public abstract class Animal : IAnimal
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void MakeSound();

    public virtual string GetInfo()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}";
    }
}

public class Horse : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Horse");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat");
    }
}

public class Hamster : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Hamster");
    }
}

public class AnimalShelter
{
    private List<Animal> animals;

    public AnimalShelter()
    {
        animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        animals.Remove(animal);
    }

    public void PrintAnimals()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetInfo());
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AnimalShelter shelter = new AnimalShelter();

        // Добавляем животных в приют
        Horse horse1 = new Horse { ID = 1, Name = "Liana", Age = 10 };
        Dog dog1 = new Dog { ID = 2, Name = "Tom", Age = 3 };
        Cat cat1 = new Cat { ID = 3, Name = "Masha", Age = 5 };
        Hamster hamster1 = new Hamster { ID = 4, Name = "Spike", Age = 1 };

        shelter.AddAnimal(horse1);
        shelter.AddAnimal(dog1);
        shelter.AddAnimal(cat1);
        shelter.AddAnimal(hamster1);

        // Выводим информацию о животных в приюте
        shelter.PrintAnimals();

        // Удаляем животное из приюта
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                shelter.RemoveAnimal(horse1);
                break;
            case 2:
                shelter.RemoveAnimal(dog1);
                break;
            case 3:
                shelter.RemoveAnimal(cat1);
                break;
            case 4:
                shelter.RemoveAnimal(hamster1);
                break;
                default:break;
        }
        Console.WriteLine("After removing an animal:");

        // Выводим информацию о животных после удаления
        shelter.PrintAnimals();

        // Проигрываем звуки животных
        dog1.MakeSound();
        horse1.MakeSound();
    }
}