// Employee directory

using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}
class Program
{
    static void Main()
    {
        List<Employee> employees =
            new List<Employee>
            {
                new Employee
                {
                    Name = "Amit",
                    Department = "IT",
                    Salary = 100000
                },
                new Employee
                {
                    Name = "Rahul",
                    Department = "IT",
                    Salary = 95000
                },
                new Employee
                {
                    Name = "Priya",
                    Department = "HR",
                    Salary = 85000
                },
                new Employee
                {
                    Name = "Kiran",
                    Department = "Sales",
                    Salary = 120000
                }
            };

        Dictionary<string, int> totals =
            new Dictionary<string, int>();

        foreach (Employee employee in employees)
        {
            if (!totals.ContainsKey(employee.Department))
            {
                totals[employee.Department] = 0;
            }
            totals[employee.Department] += employee.Salary;
        }
        string highestDept = "";
        int highestAmount = 0;

        foreach (var item in totals)
        {
            Console.WriteLine(
                $"{item.Key}: {item.Value}");

            if (item.Value > highestAmount)
            {
                highestAmount = item.Value;
                highestDept = item.Key;
            }
        }

        Console.WriteLine(
            $"Highest paying: {highestDept}");
    }
}