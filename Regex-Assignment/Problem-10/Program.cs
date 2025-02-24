using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidIPAddress(string ip)
    {
        string pattern = @"\b((25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\b";
        return Regex.IsMatch(ip, pattern);
    }

    static void Main()
    {
        string[] testIPs = { "192.168.1.1", "255.255.255.255", "256.100.50.25", "123.045.067.089", "10.0.0.256" };

        foreach (var ip in testIPs)
        {
            Console.WriteLine($"'{ip}' is {(IsValidIPAddress(ip) ? "Valid" : "Invalid")}");
        }
    }
}
