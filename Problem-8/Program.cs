using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStreamCommunication
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString()))
        {
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteToPipe(PipeStream pipeStream)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipeStream, Encoding.UTF8) { AutoFlush = true })
            {
                string[] messages = { "Hello from Writer Thread!", "C# Piped Streams", "End of Message" };

                foreach (string message in messages)
                {
                    Console.WriteLine($"Writer: Sending - {message}");
                    writer.WriteLine(message);
                    Thread.Sleep(500);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Writer Error: {ex.Message}");
        }
    }

    static void ReadFromPipe(PipeStream pipeStream)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipeStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Reader: Received - {line}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Reader Error: {ex.Message}");
        }
    }
}
