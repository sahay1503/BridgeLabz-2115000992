using System;
using System.IO;

class ModifyCSV
{
    static void Main()
    {
        string inputFilePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-6\\employees.csv";  // Input file
        string outputFilePath = "updated_employees.csv";

        try
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Write header row unchanged
                    {
                        writer.WriteLine(line);
                        isHeader = false;
                        continue;
                    }

                    string[] columns = line.Split(',');

                    if (columns[2].Trim().Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        if (decimal.TryParse(columns[3], out decimal salary))
                        {
                            salary *= 1.10m; // Increase by 10%
                            columns[3] = salary.ToString("F2"); // Format to 2 decimal places
                        }
                    }

                    writer.WriteLine(string.Join(",", columns));
                }
            }

            Console.WriteLine("Updated CSV file saved as 'updated_employees.csv'");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
