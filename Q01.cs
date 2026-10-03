// Rotate an array

using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Console.WriteLine("Before: " + string.Join(" ", arr));

        k %= arr.Length;

        Reverse(arr, 0, arr.Length - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, arr.Length - 1);

        Console.WriteLine("After: " + string.Join(" ", arr));
    }

    static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }
}