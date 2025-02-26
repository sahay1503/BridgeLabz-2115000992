using System;
using System.IO;
using System.Collections.Generic;

class MergeCSVFiles
{
    static void Main()
    {
        string file1 = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-10\\students1.csv";
        string file2 = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-10\\students2.csv";
        string outputFile = "merged_students.csv";

        Dictionary<int, string[]> studentData = new Dictionary<int, string[]>();

        try
        {
            // Read students1.csv (ID, Name, Age)
            using (StreamReader reader = new StreamReader(file1))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Skip header
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] columns = line.Split(',');
                    int id = int.Parse(columns[0]);

                    // Store ID, Name, and Age in dictionary
                    studentData[id] = new string[] { columns[1], columns[2], "", "" }; // Name, Age, Marks, Grade
                }
            }

            // Read students2.csv (ID, Marks, Grade)
            using (StreamReader reader = new StreamReader(file2))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Skip header
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] columns = line.Split(',');
                    int id = int.Parse(columns[0]);

                    // If ID exists, update Marks and Grade
                    if (studentData.ContainsKey(id))
                    {
                        studentData[id][2] = columns[1]; // Marks
                        studentData[id][3] = columns[2]; // Grade
                    }
                    else
                    {
                        // Add new entry if ID is found only in students2.csv
                        studentData[id] = new string[] { "", "", columns[1], columns[2] }; // Name, Age, Marks, Grade
                    }
                }
            }

            // Write merged data to output file
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade"); // Header

                foreach (var entry in studentData)
                {
                    writer.WriteLine($"{entry.Key},{string.Join(",", entry.Value)}");
                }
            }

            Console.WriteLine("Merged CSV file saved as 'merged_students.csv'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
