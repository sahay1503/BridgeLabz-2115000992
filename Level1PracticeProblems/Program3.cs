using System;
class Program3
{
    public static void Print()
    {
        Console.WriteLine("Enter the Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the Age");
        int age = Convert.ToInt32(Console.ReadLine());
        Person person1 = new Person(name, age);
        Person person2 = new Person(person1);
        Console.WriteLine("Details of Person 1:");
        person1.PrintDetail();
        Console.WriteLine("Details of Person 2 by copy constructor:");
        person2.PrintDetail();
    }
}
public class Person
{
    private string Name;
    private int Age;
    //  constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    // Copy constructor
    public Person(Person Object)
    {
        Name = Object.Name;
        Age = Object.Age;
    }
    // to display
    public void PrintDetail()
    {
        Console.WriteLine("Name:  " + Name + "\nAge: " + Age);
    }
}