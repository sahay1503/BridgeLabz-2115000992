// using System;
// using System.IO;

// class LargeFileGenerator
// {
//     static void Main()
//     {
//         string filePath = "largefile.dat";
//         long fileSize = 100 * 1024 * 1024; 

//         try
//         {
//             Console.WriteLine($"Creating a 100MB test file: {filePath}...");

//             using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
//             {
//                 byte[] buffer = new byte[4096]; 
//                 Random random = new Random();

//                 for (long i = 0; i < fileSize; i += buffer.Length)
//                 {
//                     random.NextBytes(buffer);  
//                     fs.Write(buffer, 0, buffer.Length);
//                 }
//             }

//             Console.WriteLine("File created successfully!");
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
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void Main()
    {
        string sourceFilePath = "largefile.dat";
        string destinationBufferedPath = "copyInBuffered.dat";
        string destinationUnbufferedPath = "copyInUnbuffered.dat";

        try
        {
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            Console.WriteLine("Starting file copy comparison...\n");

            Stopwatch sw = Stopwatch.StartNew();
            CopyFileWithoutBuffering(sourceFilePath, destinationUnbufferedPath);
            sw.Stop();
            Console.WriteLine($"Unbuffered Copy Time: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            CopyFileWithBuffering(sourceFilePath, destinationBufferedPath);
            sw.Stop();
            Console.WriteLine($"Buffered Copy Time: {sw.ElapsedMilliseconds} ms");
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
    static void CopyFileWithoutBuffering(string source, string destination)
    {
        using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                destStream.Write(buffer, 0, bytesRead);
            }
        }
    }
    static void CopyFileWithBuffering(string source, string destination)
    {
        using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedSource = new BufferedStream(sourceStream, 4096))
        using (BufferedStream bufferedDest = new BufferedStream(destStream, 4096))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = bufferedSource.Read(buffer, 0, buffer.Length)) > 0)
            {
                bufferedDest.Write(buffer, 0, bytesRead);
            }
        }
    }
}
