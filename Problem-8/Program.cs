using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-8\\employees.csv";
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Skip header row
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] columns = line.Split(',');

                    if (columns.Length < 5) // Ensure correct number of columns
                    {
                        Console.WriteLine($"Invalid row format: {line}");
                        continue;
                    }

                    string email = columns[3].Trim();
                    string phone = columns[4].Trim();

                    bool isEmailValid = Regex.IsMatch(email, emailPattern);
                    bool isPhoneValid = Regex.IsMatch(phone, phonePattern);

                    if (!isEmailValid || !isPhoneValid)
                    {
                        Console.WriteLine($"Invalid data - ID: {columns[0]}, Name: {columns[1]}, Email: {email}, Phone: {phone}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
