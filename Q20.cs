// Task scheduler

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> pending =
            new Queue<string>();

        Stack<string> completed =
            new Stack<string>();

        HashSet<string> tasks =
            new HashSet<string>();

        AddTask("Design");
        AddTask("Build");
        AddTask("Test");
        AddTask("Build");

        ProcessTask();
        ProcessTask();

        UndoTask();

        Console.WriteLine(
            $"Pending: {pending.Count}, Completed: {completed.Count}"
        );

        void AddTask(string task)
        {
            if (tasks.Add(task))
            {
                pending.Enqueue(task);

                Console.WriteLine(
                    "Added: " + task
                );
            }
            else
            {
                Console.WriteLine(
                    "Duplicate rejected: " + task
                );
            }
        }

        void ProcessTask()
        {
            string task = pending.Dequeue();

            completed.Push(task);

            Console.WriteLine(
                "Processing: " + task
            );
        }

        void UndoTask()
        {
            string task = completed.Pop();

            Console.WriteLine(
                "Undoing: " + task
            );
        }
    }
}