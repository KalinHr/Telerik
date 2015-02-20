using System;

/*Write a method that asks the user for his name and prints “Hello, <name>”
  Write a program to test this method.
  Example:
  input	  output
  Peter	  Hello, Peter!*/

class Program
    {
        static void SayHello()
        {
            Console.WriteLine("What is you name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
        static void Main()
        {
            SayHello();
        }
    }
