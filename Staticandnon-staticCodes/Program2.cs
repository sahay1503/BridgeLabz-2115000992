//File Name : Program2.cs
//Studied about static Constructor.
//Why we cant use static Constructor in Java?


using System;
namespace Constructor {
    class Program2 {
        private static int id;
        //Static constructor, value of data member id is set conditionally here.
        //This type of initialization is not possible at the time of declaration.
        static Program2() {
            if (Program2.	id < 10) {
                id = 20;
            } else {
                id = 100;
            }
            Console.WriteLine("Static<Class> Constructor for Class Program2 Called..");
        }
        public static void print() {
            Console.WriteLine("Program2.id = " + id);
        }
        static void Main(string[] args) {
            //Print the value of id
            Program2.print();
        }
    }
}