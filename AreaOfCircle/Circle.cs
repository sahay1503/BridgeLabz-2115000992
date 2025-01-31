using System;
public class Circle
{
    // Private field for radius 
    private double radius;
    // Constructor of Class Circle
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate circumference
    public double GetCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("Circle Details:");
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + GetArea());
        Console.WriteLine("Circumference: " + GetCircumference());
    }
}
