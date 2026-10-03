// Browser history with undo

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> history = new Stack<string>();

        history.Push("home");
        history.Push("products");
        history.Push("cart");
        history.Push("checkout");

        Console.WriteLine(
            "Visited (most recent first): " +
            string.Join(", ", history)
        );

        history.Pop();

        Console.WriteLine(
            "Back to: " + history.Peek()
        );

        history.Pop();

        Console.WriteLine(
            "Back to: " + history.Peek()
        );

        Console.WriteLine(
            "Current page: " + history.Peek()
        );
    }
}
