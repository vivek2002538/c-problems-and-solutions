// Student result processor

using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Mark { get; set; }
}

class Program
{
    static void Main()
    {
        string[] records =
        {
            "Amit,80",
            "Priya,abc",
            "Rahul",
            "Kiran,75",
            "Neha,82"
        };

        List<Student> students =
            new List<Student>();

        int failures = 0;

        foreach (string record in records)
        {
            string[] parts = record.Split(',');

            if (parts.Length != 2)
            {
                Console.WriteLine(
                    $"Skipped '{record}': missing mark"
                );

                failures++;
                continue;
            }

            if (!int.TryParse(parts[1], out int mark))
            {
                Console.WriteLine(
                    $"Skipped '{record}': mark is not a number"
                );

                failures++;
                continue;
            }

            students.Add(
                new Student
                {
                    Name = parts[0],
                    Mark = mark
                }
            );
        }

        double total = 0;

        foreach (Student student in students)
        {
            total += student.Mark;
        }

        Console.WriteLine(
            $"Valid students: {students.Count}"
        );

        Console.WriteLine(
            $"Average: {(total / students.Count):F2}"
        );
    }
}