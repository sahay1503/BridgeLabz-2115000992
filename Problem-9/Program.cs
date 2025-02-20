// using System;
// using System.IO;
// using System.Text;

// class LargeFileGenerator
// {
//     static void Main()
//     {
//         string filePath = "large_file.txt";
//         long targetSize = 500L * 1024 * 1024;
//         string[] logMessages =
//         {
//             "INFO: System is running smoothly.",
//             "WARNING: Disk space is low.",
//             "ERROR: Failed to connect to database.",
//             "DEBUG: Checking memory allocation.",
//             "ERROR: Unexpected null reference exception occurred.",
//             "INFO: User logged in successfully.",
//             "WARNING: High CPU usage detected.",
//             "ERROR: File not found in specified directory.",
//             "DEBUG: Entering function ProcessData()",
//             "INFO: Application shutdown initiated."
//         };

//         try
//         {
//             Console.WriteLine("Generating a large log file...");

//             using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
//             {
//                 Random rand = new Random();
//                 long currentSize = 0;

//                 while (currentSize < targetSize)
//                 {
//                     string logEntry = $"{DateTime.Now} - {logMessages[rand.Next(logMessages.Length)]}";
//                     writer.WriteLine(logEntry);
//                     currentSize += Encoding.UTF8.GetByteCount(logEntry + Environment.NewLine);
//                 }
//             }

//             Console.WriteLine($"File '{filePath}' successfully created with size 500MB+.");
//         }
//         catch (IOException ex)
//         {
//             Console.WriteLine($"I/O Error: {ex.Message}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Unexpected Error: {ex.Message}");
//         }
//     }
// }


using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class LargeFileReader
{
    static void Main()
    {
        string filePath = "large_file.txt";

        try
        {
            Console.WriteLine("Searching for lines containing 'error'...\n");
            ReadLargeFile(filePath);
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

    static void ReadLargeFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: The specified file does not exist.");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8, true, bufferSize: 4096))
        {
            string line;
            int lineNumber = 0;

            while ((line = reader.ReadLine()) != null)
            {
                lineNumber++;

                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"Line {lineNumber}: {line}");
                }
            }
        }
    }
}
