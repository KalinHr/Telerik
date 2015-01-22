using System;

/*Write a program that enters 5 numbers (given in a single line, separated by a space), 
  calculates and prints their sum.*/

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("5 numbers (in a single line, separated by a space): ");
        string numbers = Convert.ToString(Console.ReadLine());
        double sum = 0;
        string s = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == ' ')
            {   sum = sum + double.Parse(s);
                s = ""; }
            else
                s = s + numbers[i];
        }
        sum = sum + double.Parse(s);
        Console.WriteLine(sum);
    }
}
