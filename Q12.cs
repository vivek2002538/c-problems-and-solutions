// Array index guard

using System;

class Program
{
    static void Main()
    {
        int[] marks = { 50, 60, 70, 80, 90 };

        try
        {
            Console.Write("Enter an index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(marks[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine(
                "That position does not exist (valid: 0 to 4)"
            );
        }
        finally
        {
            Console.WriteLine("Lookup attempted");
        }
    }
}