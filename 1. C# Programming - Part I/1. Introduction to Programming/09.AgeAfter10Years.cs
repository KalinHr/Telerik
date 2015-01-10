using System;

/*Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Your age? ");
        int age = Convert.ToInt32(Console.ReadLine());
        age = age + 10;
        Console.WriteLine(age);
    }
}

