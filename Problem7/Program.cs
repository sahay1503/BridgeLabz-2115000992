using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "file.txt"; 

        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8)) // Specify the encoding
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("File Content:\n" + content);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
    }
}
