using System;
using System.IO;
using System.Text;

class UpperToLowerConverter
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            // Read from source file and write to destination file
            ConvertToLowercase(sourceFile, destinationFile);
            Console.WriteLine($"Conversion completed! Output saved in {destinationFile}");
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

    static void ConvertToLowercase(string sourcePath, string destinationPath)
    {
        // Open the files using BufferedStream for efficiency
        using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedSource = new BufferedStream(sourceStream))
        using (StreamReader reader = new StreamReader(bufferedSource, Encoding.UTF8))

        using (FileStream destStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedDest = new BufferedStream(destStream))
        using (StreamWriter writer = new StreamWriter(bufferedDest, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());  // Convert to lowercase before writing
            }
        }
    }
}
