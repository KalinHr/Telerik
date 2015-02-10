using System;

/*Write a program that reads two integer numbers N and K and an array of N elements from the console.
  Find in the array those K elements that have maximal sum.*/

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] maxK = new int[k];
        for (int i = 0; i < k; i++)
        {
            int num = arr[0];
            int helper = 0;
            for (int j = 1; j < length - i; j++)
                if (arr[j] > num)
                {
                    num = arr[j];
                    helper = j;
                }
            arr[helper] = arr[length - 1];
            maxK[i] = num;
        }
        int maxSum = maxK[k-1];
        Console.WriteLine("elements: ");
        for (int i = 0; i < k - 1; i++)
        {
            Console.Write(maxK[i] + ", ");
            maxSum += maxK[i];
        }
        Console.WriteLine(maxK[k - 1]);
        Console.WriteLine("maximal sum: ");
        Console.WriteLine(maxSum);
    }
}