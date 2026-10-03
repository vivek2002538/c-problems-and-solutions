// Validating a registration

using System;

class Program
{
    static void Main()
    {
        try
        {
            Register("Amit", 24);
            Register("", 24);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Register("Rahul", 12);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Register(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Name cannot be empty"
            );
        }

        if (age < 18 || age > 100)
        {
            throw new ArgumentOutOfRangeException(
                "age",
                "Age must be between 18 and 100"
            );
        }

        Console.WriteLine(
            $"Registered {name}, age {age}"
        );
    }
}