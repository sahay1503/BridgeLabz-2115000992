using System;
using System.IO;

class FileHandlingExample
{
    static void Main()
    {
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt";

        try
        {
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }

                Console.WriteLine("File copied successfully.");
            }
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
}
