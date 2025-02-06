//Main Program
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating school
        School mySchool = new School("Bal Vidyapeeth Public School,Aonla");

        // Creating students
        Student student1 = new Student("Nishant Chauhan");
        Student student2 = new Student("Piyush Kumar Singh");

        // Adding students to the school
        mySchool.AddStudent(student1);
        mySchool.AddStudent(student2);

        // Creating courses
        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        // Enrolling students in courses
        math.EnrollStudent(student1);
        math.EnrollStudent(student2);
        science.EnrollStudent(student1);

        // Displaying students and their courses
        student1.ViewEnrolledCourses();
        student2.ViewEnrolledCourses();

        // Displaying courses and their enrolled students
        math.DisplayEnrolledStudents();
        science.DisplayEnrolledStudents();
    }
}
