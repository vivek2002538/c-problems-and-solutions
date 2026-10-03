// Inventory with full error handling

using System;
using System.Collections.Generic;

class Inventory
{
    private Dictionary<string, int> products =
        new Dictionary<string, int>
        {
            { "P001", 12 },
            { "P002", 2 },
            { "P003", 8 }
        };

    public void Sell(
        string code,
        int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException(
                "Quantity must be positive"
            );
        }

        if (!products.ContainsKey(code))
        {
            throw new KeyNotFoundException(
                $"Unknown product: {code}"
            );
        }

        if (products[code] < quantity)
        {
            throw new InvalidOperationException(
                $"Not enough {code}: have {products[code]}, need {quantity}"
            );
        }

        products[code] -= quantity;

        Console.WriteLine(
            $"Sold {quantity} {code}. Remaining: {products[code]}"
        );
    }

    public void Report()
    {
        Console.WriteLine(
            $"Final stock: P001={products["P001"]}, P002={products["P002"]}, P003={products["P003"]}"
        );
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        try
        {
            inventory.Sell("P001", 3);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            inventory.Sell("P002", 5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            inventory.Sell("P999", 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            inventory.Sell("P001", -2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        inventory.Report();
    }
}