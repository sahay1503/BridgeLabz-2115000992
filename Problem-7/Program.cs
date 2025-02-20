using System;
using System.IO;

class StudentDataBinary
{
    static string filePath = "students.dat";

    static void Main()
    {
        try
        {
            WriteStudentData();
            Console.WriteLine("Student data has been stored successfully!\n");

            ReadStudentData();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }

    static void WriteStudentData()
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101);
            writer.Write("Pradeep Kumar");
            writer.Write(3.8);

            writer.Write(102);
            writer.Write("Ravi Singh");
            writer.Write(3.6);
        }
    }

    static void ReadStudentData()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No student data found.");
            return;
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            Console.WriteLine("Retrieving student data from binary file:\n");

            while (fs.Position < fs.Length)
            {
                int rollNumber = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();

                Console.WriteLine($"Roll Number: {rollNumber}, Name: {name}, GPA: {gpa}");
            }
        }
    }
}
