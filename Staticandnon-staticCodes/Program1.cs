
// Static to static 
// * Static methods can be called directly in static context or by creating instance
using System;

class Program1 {
    // Static Method
    public static void StaticMethod() {
        Console.WriteLine("Static Method Called.");
    }

    static void Main(string[] args) {
        // Calling a static method from a static context
        Program1.StaticMethod();  // OK
        StaticMethod();          // OK (direct call in static context)
    }
}


// Static calling non-static
// * we cannot call non-static directly in static method first we have to create an instance  to call non-static methods.
/*using System;

class Program1 {
    // Non-Static Method
    public void NonStaticMethod() {
        Console.WriteLine("Non-Static Method Called.");
    }

    static void Main(string[] args) {
        // Calling a non-static method from a static context
        // This will result in an error, because you need an instance to call non-static methods
        // Example.NonStaticMethod(); // ERROR
        Program1 obj = new Example();
        obj.NonStaticMethod(); // OK (create an instance to call)
    }
}
*/

//non-static calling non-static
// we can directly call the non-static method inside non-static methods 
/*using System;

class Program1 {
    // Non-Static Method 1
    public void FirstNonStaticMethod() {
        Console.WriteLine("First Non-Static Method Called.");
    }

    // Non-Static Method 2
    public void SecondNonStaticMethod() {
        // Calling another non-static method from a non-static context
        FirstNonStaticMethod();  // OK (calling another non-static method)
    }

    static void Main(string[] args) {
		Program1 obj = new Example();
        obj.SecondNonStaticMethod(); // OK (calling non-static method)
    }
}
*/

//non-static calling static 
// * we can call directly by the name of that static method or via className of that static method.
/*
using System;

class Program1 {
    // Static Method
    public static void StaticMethod() {
        Console.WriteLine("Static Method Called.");
    }

    // Non-Static Method
    public void NonStaticMethod() {
        // Calling a static method from a non-static context
        StaticMethod();  // OK (can directly call static method)
    }

    static void Main(string[] args) {
        Program1 obj = new Example();
        obj.NonStaticMethod(); // OK (calling non-static method)
    }
}
*/



