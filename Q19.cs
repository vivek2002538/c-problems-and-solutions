// Bank account manager

using System;
using System.Collections.Generic;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message)
        : base(message)
    {
    }
}

class Bank
{
    private Dictionary<string, decimal> accounts =
        new Dictionary<string, decimal>();

    public void AddAccount(
        string accountNumber,
        decimal balance)
    {
        accounts[accountNumber] = balance;
    }

    public void Deposit(
        string accountNumber,
        decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Amount must be positive"
            );
        }

        if (!accounts.ContainsKey(accountNumber))
        {
            throw new KeyNotFoundException(
                $"No account: {accountNumber}"
            );
        }

        accounts[accountNumber] += amount;

        Console.WriteLine(
            $"Deposited {amount}. Balance: {accounts[accountNumber]}"
        );
    }

    public void Withdraw(
        string accountNumber,
        decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Amount must be positive"
            );
        }

        if (!accounts.ContainsKey(accountNumber))
        {
            throw new KeyNotFoundException(
                $"No account: {accountNumber}"
            );
        }

        if (accounts[accountNumber] < amount)
        {
            throw new InsufficientFundsException(
                $"Cannot withdraw {amount}, balance is {accounts[accountNumber]}"
            );
        }

        accounts[accountNumber] -= amount;
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank();

        bank.AddAccount("ACC101", 5000);

        try
        {
            bank.Deposit("ACC101", 2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            bank.Withdraw("ACC101", 9000);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            bank.Deposit("ACC999", 100);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            bank.Deposit("ACC101", -5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}