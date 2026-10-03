// Support ticket queue

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> tickets = new Queue<string>();

        tickets.Enqueue("T101");
        tickets.Enqueue("T102");
        tickets.Enqueue("T103");
        tickets.Enqueue("T104");

        Console.WriteLine("Serving: " + tickets.Dequeue());
        Console.WriteLine("Serving: " + tickets.Dequeue());

        Console.WriteLine("Next up: " + tickets.Peek());
        Console.WriteLine("Still waiting: " + tickets.Count);
    }
}