using System;
using System.IO;

class ReadLargeCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-11\\large_dataset.csv";
        int batchSize = 100;
        int totalRecords = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int batchCount = 0;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    batchCount++;
                    totalRecords++;

                    if (batchCount == batchSize)
                    {
                        Console.WriteLine($"Processed {totalRecords} records...");
                        batchCount = 0;
                    }
                }

                Console.WriteLine($"Total records processed: {totalRecords}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
