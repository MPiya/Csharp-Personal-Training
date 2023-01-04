public class Animal
{
    public virtual void MakeNoise()
    {
        Console.WriteLine("Some generic animal noise");
    }
}

public class Dog : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Meow!");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeNoise(); // Output: "Some generic animal noise"

        Animal dog = new Dog();
        dog.MakeNoise(); // Output: "Woof!"

        Animal cat = new Cat();
        cat.MakeNoise(); // Output: "Meow!"
    }
}