using System;

/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please choose a type: ");
        int type = Convert.ToInt32(Console.ReadLine());
        if (type == 1)
        {
            Console.Write("Please enter a int: ");
            int x = Convert.ToInt32(Console.ReadLine()) + 1;
            Console.WriteLine("Result: " + x);
        }
        if (type == 2)
        {
            Console.Write("Please enter a double: ");
            double x = Convert.ToDouble(Console.ReadLine()) + 1;
            Console.WriteLine("Result: " + x);
        }
        if (type == 3)
        {
            Console.Write("Please enter a string: ");
            string x = Console.ReadLine() + "*";
            Console.WriteLine("Result: " + x);
        }
    }
}
