// Balanced brackets

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Test("{[()]}");
        Test("{[(])}");
        Test("((");
    }

    static void Test(string input)
    {
        Console.WriteLine(
            input + " -> " +
            (IsBalanced(input) ? "balanced" : "not balanced")
        );
    }

    static bool IsBalanced(string text)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in text)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();

                if ((ch == ')' && top != '(') ||
                    (ch == ']' && top != '[') ||
                    (ch == '}' && top != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
