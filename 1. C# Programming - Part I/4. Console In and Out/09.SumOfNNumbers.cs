using System;

/*Write a program that enters a number n and after that enters more n numbers 
  and calculates and prints their sum.*/

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("n{0} = ", i);
            sum = sum + Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("sum = " + sum);
    }
}
