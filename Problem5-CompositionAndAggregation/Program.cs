//Main Program
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Creating university
        University myUniversity = new University("Tech University");

        // Adding departments (Composition - tied to university lifespan)
        myUniversity.AddDepartment("Computer Science");
        myUniversity.AddDepartment("Mechanical Engineering");

        // Creating faculty members (Aggregation - independent existence)
        Faculty profAlice = new Faculty("Alice", "Artificial Intelligence");
        Faculty profBob = new Faculty("Bob", "Thermodynamics");

        // Adding faculty to university
        myUniversity.AddFaculty(profAlice);
        myUniversity.AddFaculty(profBob);

        // Displaying university structure
        myUniversity.DisplayUniversity();
    }
}
