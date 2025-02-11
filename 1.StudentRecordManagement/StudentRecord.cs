class StudentRecord
{
    private Student head;

    //Add a student record at the beginning
    public void AddAtBeginning(int rollNumber, string name, int age, char grade)
    {
        Student newstudent = new Student(rollNumber, name, age, grade);
        newstudent.Next = head;
        head = newstudent;
        Console.WriteLine("Student Record is added at the beginning");
    }
    //Add a student record at the end
    public void AddAtEnd(int rollNumber, string name, int age, char grade)
    {
        Student newstudent = new Student(rollNumber, name, age, grade);
        if (head == null)
        {
            head = newstudent;
            return;
        }
        Student temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newstudent;
        Console.WriteLine("Student Record is added at the end");
    }
    //Add a student Record at the specific position
    public void AddAtPosition(int rollNumber, string name, int age, char grade, int position)
    {
        Student newstudent = new Student(rollNumber, name, age, grade);
        if (position == 0)
        {
            Console.WriteLine("Invalid Position");
            return;
        }
        if (position == 1)
        {
            AddAtBeginning(rollNumber, name, age, grade);
            return;
        }
        Student temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;

        }
        if (temp == null)
        {
            Console.WriteLine("Position out of Range");
        }
        newstudent.Next = temp.Next;
        temp.Next = newstudent;
        Console.WriteLine($"Student Added at position {position}.");
    }
    //Delete a Student Record by RollNumber
    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("No Student Record Found");
            return;
        }
        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            Console.WriteLine($"Student with RollNumber {rollNumber} is deleted");
            return;
        }
        Student temp = head, prev = null;
        while (temp != null && temp.Next.RollNumber != rollNumber)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Student Not Found");
            return;
        }
        prev.Next = temp.Next;
        Console.WriteLine($"Student with this Roll Number {rollNumber} is deleted.");
    }
    //Search for a student record by Roll Number
    public void SearchByRollNumber(int rollNumber)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                Console.WriteLine($"Student Found: Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }
    //Display all Student Records
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No student records available.");
            return;
        }

        Student temp = head;
        Console.WriteLine("Student Records:");
        while (temp != null)
        {
            Console.WriteLine($"Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
    //Update a student's grade based on their Roll Number
    public void UpdateGrade(int rollNumber, char newGrade)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                temp.Grade = newGrade;
                Console.WriteLine($"Grade updated for Roll Number {rollNumber}.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }
}