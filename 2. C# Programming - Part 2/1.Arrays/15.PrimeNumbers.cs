using System;

/*Write a program that finds all prime numbers in the range [1...10 000 000].
  Use the Sieve of Eratosthenes algorithm.*/

class Program
{
    static void Main()
    {
        const long size = 10000000;
        bool[] prime = new bool[size + 1];
        prime[0] = false;
        prime[1] = false;
        for (int i = 2; i <= size; i++)
            prime[i] = true;
        for (long i = 2; i <= size; i++)
            if (prime[i] == true)
            {
                Console.Write(i +  " ");
                for (long j = i * i; j <= size; j += i)
                    prime[j] = false;
            }   
    }
}
