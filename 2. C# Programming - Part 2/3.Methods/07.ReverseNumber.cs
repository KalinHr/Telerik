using System;

/*Write a method that reverses the digits of given decimal number.
  Example:
  input	    output
  256	    652
  123.45	54.321
 */

class Program
{
    static double Reverse(double number)
    {
        string helper = Convert.ToString(number);
        char[] c = new char[helper.Length];
        for (int i = 0; i < helper.Length; i++)
            c[i] = helper[i];
        for (int i = 0; i < c.Length / 2; i++)
        {
            char x = c[i];
            c[i] = c[c.Length - (1 + i)];
            c[c.Length - (1 + i)] = x;
        }
        helper = "";
        for (int i = 0; i < c.Length; i++)
            helper = helper + c[i];
        return double.Parse(helper);
    }
    static void Main()
    {
        Console.Write("number = ");
        double number = double.Parse(Console.ReadLine());
        number = Reverse(number);
        Console.WriteLine(number);
    }
}