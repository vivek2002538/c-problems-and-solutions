// Unique visitors

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> logs = new List<string>
        {
            "U1",
            "U2",
            "U1",
            "U3",
            "U2",
            "U4",
            "U5",
            "U5"
        };
        HashSet<string> uniqueUsers =
            new HashSet<string>();

        int repeats = 0;

        foreach (string user in logs)
        {
            if (!uniqueUsers.Add(user))
            {
                repeats++;
            }
        }

        Console.WriteLine($"Log entries: {logs.Count}");
        Console.WriteLine($"Unique visitors: {uniqueUsers.Count}");
        Console.WriteLine($"Repeat entries: {repeats}");
    }
}