using System;
using System.IO;

class WriteCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-2\\employees.csv";
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Writing the header
                writer.WriteLine("ID,Name,Department,Salary");

                // Writing 5 employee records
                writer.WriteLine("101,John Doe,Engineering,60000");
                writer.WriteLine("102,Jane Smith,HR,50000");
                writer.WriteLine("103,Michael Brown,Marketing,55000");
                writer.WriteLine("104,Alice Williams,Finance,62000");
                writer.WriteLine("105,Bob Johnson,Sales,58000");
            }
            Console.WriteLine("CSV file written successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
