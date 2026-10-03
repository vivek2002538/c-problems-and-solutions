// Safe division

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Result = " + (a / b));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
    }
}