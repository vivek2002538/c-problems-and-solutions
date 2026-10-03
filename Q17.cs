// Retry with a limit

using System;

class Program
{
    static void Main()
    {
        int attempts = 0;

        while (attempts < 3)
        {
            try
            {
                Console.Write(
                    $"Attempt {attempts + 1}: "
                );

                int number =
                    int.Parse(Console.ReadLine());

                Console.WriteLine(
                    "You entered " + number
                );

                return;
            }
            catch
            {
                Console.WriteLine(
                    "Not a number"
                );
            }

            attempts++;
        }

        Console.WriteLine(
            "Maximum attempts exceeded"
        );
    }
}