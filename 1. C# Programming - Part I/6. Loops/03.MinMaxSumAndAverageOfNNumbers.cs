using System;

/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the 
  maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
  The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
  The output is like in the examples below.*/

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double[] m = new double[n];
        for (int i = 0; i < n; i++)
            m[i] = Convert.ToInt32(Console.ReadLine());
        double min = m[0];
        double max = m[0];
        double sum = m[0], avg;
        for (int i = 1; i < n; i++)
        {
            if (m[i] < min)
                min = m[i];
            if (m[i] > max)
                max = m[i];
            sum += m[i];
        }
        avg = sum / n;
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:0.00}", avg);
    }
}
