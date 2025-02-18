using System;
using System.Collections.Generic;

// Interface defining a meal plan
interface IMealPlan
{
    string GetMealDetails();
}

// Different meal plan implementations
class VegetarianMeal : IMealPlan
{
    public string GetMealDetails() => "Vegetarian Meal: Includes vegetables, grains, and dairy.";
}

class VeganMeal : IMealPlan
{
    public string GetMealDetails() => "Vegan Meal: Includes only plant-based foods.";
}

class KetoMeal : IMealPlan
{
    public string GetMealDetails() => "Keto Meal: Low-carb, high-fat foods.";
}

class HighProteinMeal : IMealPlan
{
    public string GetMealDetails() => "High-Protein Meal: Focuses on protein-rich foods like chicken, fish, and beans.";
}

// Generic class for meal
class Meal<T> where T : IMealPlan, new()
{
    public T MealType { get; set; }

    public Meal()
    {
        MealType = new T();
    }

    public void DisplayMeal()
    {
        Console.WriteLine(MealType.GetMealDetails());
    }
}

// Meal plan manager
class MealPlanGenerator
{
    // Generic method to create and validate a meal plan
    public static void GenerateMealPlan<T>() where T : IMealPlan, new()
    {
        Meal<T> meal = new Meal<T>();
        Console.WriteLine("Your meal plan:");
        meal.DisplayMeal();
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect a meal plan:");
            Console.WriteLine("1. Vegetarian\n2. Vegan\n3. Keto\n4. High-Protein\n5. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    MealPlanGenerator.GenerateMealPlan<VegetarianMeal>();
                    break;
                case "2":
                    MealPlanGenerator.GenerateMealPlan<VeganMeal>();
                    break;
                case "3":
                    MealPlanGenerator.GenerateMealPlan<KetoMeal>();
                    break;
                case "4":
                    MealPlanGenerator.GenerateMealPlan<HighProteinMeal>();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
