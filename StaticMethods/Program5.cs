/*1. Overloading Static Methods
Yes, you can overload static methods in both Java and C#
Reason:
Overloading occurs within the same class (or in a subclass), and it is determined at compile-time based on the method signature (method name and parameter list).
Static methods are also resolved at compile-time, so there is no conflict when overloading static methods.*/
/*
using System;
class Program5 {
    // Static method 1
    public static void Display() {
        Console.WriteLine("No arguments");
    }

    // Overloaded static method 2
    public static void Display(string message) {
        Console.WriteLine("Message: " + message);
    }

    static void Main(string[] args) {
        Program5.Display();                  // Calls the first method
        Program5.Display("Hello, C#!");      // Calls the overloaded method
    }
}
*/
/*2. Overriding Static Methods
No, you cannot override static methods in either Java or C#.
Method Hiding:-static methods in C# cannot be overridden. If you declare a static method with the same name
and signature in a derived class, it is considered method hiding.
*/

using System;

class Parent {
    public static void Show() {
        Console.WriteLine("Static method in Parent");
    }
}

class Child : Parent {
    public static void Show() {  // Method hiding, not overriding
        Console.WriteLine("Static method in Child");
    }
}

class Program5 {
    static void Main(string[] args) {
        Parent parent = new Child();
        Parent.Show();  // Calls Parent's static method (not overridden)
    }
}

