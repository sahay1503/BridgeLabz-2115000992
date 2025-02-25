using System;

public class Animal
{
    // Virtual method to allow overriding in derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Overriding the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks: Woof! Woof!");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating an instance of Dog
        Animal myDog = new Dog();

        // Calling the overridden method
        myDog.MakeSound();  // Output: The dog barks: Woof! Woof!
    }
}
