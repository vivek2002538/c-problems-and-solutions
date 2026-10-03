// Choosing the right collection

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> printJobs = new Queue<string>();

        HashSet<string> emails = new HashSet<string>();

        Dictionary<string, decimal> products =
            new Dictionary<string, decimal>();

        Stack<string> undoHistory =
            new Stack<string>();

        Console.WriteLine("Queue");
        Console.WriteLine("HashSet");
        Console.WriteLine("Dictionary");
        Console.WriteLine("Stack");
    }
}