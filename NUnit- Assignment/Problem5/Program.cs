using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection conn = new DatabaseConnection();
            conn.Connect();
            Console.WriteLine(conn.IsConnected());
            conn.Disconnect();
            Console.WriteLine(conn.IsConnected() );         
        }
    }
}
