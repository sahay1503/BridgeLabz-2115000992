//Main Program
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Creating university
        University myUniversity = new University("Tech University");

        // Creating professors
        Professor profPrabhat = new Professor("Dr. Prabhat", "Computer Science");
        Professor profUmesh = new Professor("Dr. Umesh", "Mathematics");

        // Creating students
        Student studentVivek = new Student("Vivek");
        Student studentAmit = new Student("Amit");

        // Creating courses
        Course cs101 = new Course("Introduction to Computer Science");
        Course math101 = new Course("Engineering Mathematics-III");

        // Assigning professors
        cs101.AssignProfessor(profPrabhat);
        math101.AssignProfessor(profUmesh);

        // Enrolling students in courses
        studentVivek.EnrollCourse(cs101);
        studentVivek.EnrollCourse(math101);
        studentAmit.EnrollCourse(math101);

        // Adding professors, students, and courses to university
        myUniversity.AddProfessor(profPrabhat);
        myUniversity.AddProfessor(profUmesh);
        myUniversity.AddStudent(studentVivek);
        myUniversity.AddStudent(studentAmit);
        myUniversity.AddCourse(cs101);
        myUniversity.AddCourse(math101);

        // Displaying university structure
        myUniversity.DisplayUniversity();
    }
}
