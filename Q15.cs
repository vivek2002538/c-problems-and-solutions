// Custom exception with data

using System;

class InsufficientStockException : Exception
{
    public string ProductName { get; }
    public int QuantityRequested { get; }
    public int QuantityAvailable { get; }

    public InsufficientStockException(
        string productName,
        int quantityRequested,
        int quantityAvailable)
        : base(
            $"Requested {quantityRequested} {productName} but only {quantityAvailable} available"
        )
    {
        ProductName = productName;
        QuantityRequested = quantityRequested;
        QuantityAvailable = quantityAvailable;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Sell("Laptop", 10, 4);
        }
        catch (InsufficientStockException ex)
        {
            Console.WriteLine(ex.Message);

            int shortfall =
                ex.QuantityRequested - ex.QuantityAvailable;

            Console.WriteLine(
                $"Short by {shortfall}"
            );
        }
    }

    static void Sell(
        string productName,
        int quantityRequested,
        int quantityAvailable)
    {
        if (quantityRequested > quantityAvailable)
        {
            throw new InsufficientStockException(
                productName,
                quantityRequested,
                quantityAvailable
            );
        }

        Console.WriteLine("Sale completed");
    }
}