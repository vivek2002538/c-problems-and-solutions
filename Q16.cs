// Rethrowing without losing the trace

using System;

class Program
{
    static void Main()
    {
        try
        {
            Process();
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "Caller handled: " + ex.Message
            );
        }
    }

    static void Process()
    {
        try
        {
            int a = 10;
            int b = 0;

            Console.WriteLine(a / b);
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "LOG: " + ex.Message
            );

            throw;
        }
    }
}