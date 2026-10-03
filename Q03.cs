// Find duplicates in a list

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            3, 7, 3, 9, 7, 1, 3
        };
        Dictionary<int, int> counts =
            new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts[number] = 1;
            }
        }
        Console.WriteLine("Duplicates:");
        foreach (var item in counts)
        {
            if (item.Value > 1)
            {
                Console.WriteLine(
                    $"{item.Key} appears {item.Value} times");
            }
        }
    }
}