using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CsvHelper;

class Program
{
    private static readonly string EncryptionKey = "MySecretKey12345"; // 16, 24, or 32 bytes long

    static void Main()
    {
        string csvFilePath = "employees_encrypted.csv";

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Write Encrypted CSV");
        Console.WriteLine("2. Read & Decrypt CSV");
        Console.Write("Enter choice (1/2): ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            WriteEncryptedCSV(csvFilePath);
        }
        else if (choice == "2")
        {
            ReadAndDecryptCSV(csvFilePath);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }

    static void WriteEncryptedCSV(string filePath)
    {
        var employees = new List<Employee>
        {
            new Employee { ID = 101, Name = "John Doe", Department = "IT", Salary = Encrypt("60000"), Email = Encrypt("john.doe@example.com") },
            new Employee { ID = 102, Name = "Jane Smith", Department = "HR", Salary = Encrypt("50000"), Email = Encrypt("jane.smith@example.com") }
        };

        try
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(employees);
            }
            Console.WriteLine("✅ Encrypted CSV file written successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    static void ReadAndDecryptCSV(string filePath)
    {
        try
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<Employee>();

                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {Decrypt(emp.Salary)}, Email: {Decrypt(emp.Email)}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    public static string Encrypt(string text)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
            aes.IV = new byte[16]; // Zero IV for simplicity (use a random IV in real-world cases)
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] inputBytes = Encoding.UTF8.GetBytes(text);
            byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
            return Convert.ToBase64String(encryptedBytes);
        }
    }

    public static string Decrypt(string cipherText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
            aes.IV = new byte[16]; // Must match encryption IV
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            byte[] inputBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedBytes = decryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}

// Employee class
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Salary { get; set; }  // Encrypted
    public string Email { get; set; }   // Encrypted
}
