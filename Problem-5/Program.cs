using System;
using System.IO;
using System.Linq;

class ImageByteArrayConverter
{
    static void Main()
    {
        string sourceImagePath = "rabbit.jpg";
        string destinationImagePath = "copy_rabbit.jpg";

        try
        {
            byte[] imageData = ImageToByteArray(sourceImagePath);
            Console.WriteLine($"Image converted to byte array. Size: {imageData.Length} bytes");

            ByteArrayToImage(imageData, destinationImagePath);
            Console.WriteLine($"Byte array successfully written to {destinationImagePath}");

            bool isIdentical = CompareFiles(sourceImagePath, destinationImagePath);
            Console.WriteLine($"File integrity check: {(isIdentical ? "Success - Files are identical" : "Failure - Files are different")}");
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

    static byte[] ImageToByteArray(string imagePath)
    {
        return File.ReadAllBytes(imagePath);
    }

    static void ByteArrayToImage(byte[] byteArray, string outputPath)
    {
        File.WriteAllBytes(outputPath, byteArray);
    }

    static bool CompareFiles(string file1, string file2)
    {
        byte[] file1Bytes = File.ReadAllBytes(file1);
        byte[] file2Bytes = File.ReadAllBytes(file2);

        return file1Bytes.SequenceEqual(file2Bytes);
    }
}
