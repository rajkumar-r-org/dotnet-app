using System;

class Program
{
    static void Main(string[] args)
    {
        string hostName = System.Net.Dns.GetHostName();
        DateTime currentDateTime = DateTime.Now;

        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Hostname: {hostName}");
        Console.WriteLine($"Current Time: {currentDateTime}");
    }
}
