using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class DatabaseConnection
    {
        private bool isConnected;

        public void Connect()
        {
            isConnected = true;
            Console.WriteLine("Database connected.");
        }

        public void Disconnect()
        {
            isConnected = false;
            Console.WriteLine("Database disconnected.");
        }

        public bool IsConnected()
        {
            return isConnected;
        }
    }
}
