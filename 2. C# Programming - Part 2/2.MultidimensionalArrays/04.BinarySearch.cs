using System;

/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
  and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

class Program
{
    static void SelectionSort(int[] arr, int length)
    {
        int counter = 0;
        while (length > counter + 1)
        {
            int min = arr[counter];
            int position = counter;
            for (int i = counter + 1; i < length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    position = i;
                }
            }
            arr[position] = arr[counter];
            arr[counter] = min;
            counter++;
        }
    }

    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        SelectionSort(arr, n);

        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        int index = Array.BinarySearch(arr, k);
        if (index > 0)
            Console.WriteLine(arr[index]);
        else
            Console.WriteLine(arr[-(index) - 2]);
    }
}
