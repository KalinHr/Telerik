using System;

/*Write an expression that checks if given positive integer number n (n = 100) is prime 
  (i.e. it is divisible without remainder only to itself and 1).*/


class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("number = ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool prime = true;
        if (number <= 1)
            prime = false;
        else
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    prime = false;
        Console.WriteLine(prime);
    }
}

