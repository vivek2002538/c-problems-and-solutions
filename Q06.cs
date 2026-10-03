// Common and exclusive skills

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        HashSet<string> amit = new HashSet<string>
        {
            "C#",
            "SQL",
            "Python"
        };

        HashSet<string> rohit = new HashSet<string>
        {
            "C#",
            "SQL",
            "React",
            "Azure"
        };
        HashSet<string> shared = new HashSet<string>(amit);
        shared.IntersectWith(rohit);
        HashSet<string> onlyAmit = new HashSet<string>(amit);
        onlyAmit.ExceptWith(rohit);
        HashSet<string> allSkills = new HashSet<string>(amit);
        allSkills.UnionWith(rohit);
        Console.WriteLine("Shared: " + string.Join(", ", shared));
        Console.WriteLine("Only Amit: " + string.Join(", ", onlyAmit));
        Console.WriteLine("All Skills: " + string.Join(", ", allSkills));
    }
}