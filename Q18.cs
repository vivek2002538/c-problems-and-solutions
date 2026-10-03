// Order of catch blocks

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            TestException(1);
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine("Caught: key not found");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Caught: divide by zero");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Caught: invalid format");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught: general exception");
        }
        finally
        {
            Console.WriteLine("Cleanup complete");
        }
    }
    static void TestException(int option)
    {
        if (option == 1)
        {
            Dictionary<int, string> data =
                new Dictionary<int, string>();

            string value = data[100];
        }
        else if (option == 2)
        {
            int a = 10;
            int b = 0;
            Console.WriteLine(a / b);
        }
        else if (option == 3)
        {
            int number = int.Parse("ABC");
        }
        else
        {
            throw new Exception("Unknown error");
        }
    }
}