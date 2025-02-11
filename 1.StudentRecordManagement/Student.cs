class Student
{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public Student Next;

    public Student(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
     }
}