using System;

namespace bubble_sort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];

        Console.WriteLine("Masukkan data:");

        for (int i = 0; i < n; i++)
        {
            data[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Data sebelum diurutkan:");
        PrintArray(data);

        BubbleSortAlgorithm(data);

        Console.WriteLine("Data setelah diurutkan:");
        PrintArray(data);
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Tukar elemen
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
}
