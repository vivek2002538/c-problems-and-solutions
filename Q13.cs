// Dictionary lookup, two ways

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> marks =
            new Dictionary<string, int>
            {
                { "Amit", 90 },
                { "Priya", 85 }
            };

        try
        {
            Console.WriteLine(marks["Kiran"]);
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine(
                "Kiran not found (exception version)"
            );
        }

        if (!marks.TryGetValue("Kiran", out int mark))
        {
            Console.WriteLine(
                "Kiran not found (TryGetValue version)"
            );
        }
    }
}