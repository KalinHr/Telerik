using System;

/*Write a program that converts a number in the range [0…999] to words, 
  corresponding to the English pronunciation.*/

class NumberAsWords
{
    static void Main()
    {
        string[] a = {"zero", "one", "two", "three" , "four", "five", "six", "seven", "eight", "nine"};
        string[] b = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] c = {"twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
        Console.Write("number[0..999] = ");
        int number = Convert.ToInt32(Console.ReadLine());
        string word = "";
        if (number >= 0 && number < 1000)
        {
            if (number >= 100)
            {    
                word = word + a[number / 100] + " hundred";
                number = number % 100;
            }
            if (number > 0 && word != "")
                word = word + " and ";
            if (number >= 20 && number < 100)
            {
                word = word + c[(number / 10) - 2] + " ";
                number = number % 10;
            }
            if (number >= 10 && number < 20)
            {
                word = word + b[(number % 10)] + " ";
                number = 0;
            }
            if (number > 0 && number < 10)
                word = word + a[number];
            if (number == 0 && word == "")
                word = a[number];
        }
        Console.WriteLine(word);
    }
}

