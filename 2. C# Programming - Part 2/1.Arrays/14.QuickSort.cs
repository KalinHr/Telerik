using System;

/*Write a program that sorts an integers of strings using the Quick sort algorithm.*/

class Program
{
    static int Partition(int[] arr,int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
                left++;
            while (arr[right] > pivot)
                right--;
            if (arr[right] == pivot && arr[left] == pivot)
                left++;
            if (left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
            }
            else
                return right;
        }
    }
    static void QuickSort(int[] arr,int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            if(pivot > 1)
                QuickSort(arr, left, pivot - 1);
            if(pivot + 1 < right)
                QuickSort(arr, pivot + 1, right);
        }
    }
    static void Main()
    {
        Console.Write("lenght = ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        QuickSort(arr, 0, length-1);

        for (int i = 0; i < length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
