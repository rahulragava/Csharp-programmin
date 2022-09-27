class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("animal makes sound");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("bow bow");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("meow meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new { b = 100 };
        Console.WriteLine(a.b);     // trying out the anonymous type
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();
        Animal dog1 = new Dog();
        animal.animalSound();
        dog.animalSound();
        cat.animalSound();
        dog1.animalSound();
    }
}