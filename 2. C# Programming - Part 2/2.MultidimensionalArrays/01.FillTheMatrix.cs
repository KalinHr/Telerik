using System;

/*
 Write a program that fills and prints a matrix of size (n, n) as shown below:
 Example for n=4:

a)
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
c)
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
 */

class Program
{
    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("size = ");
        int size = int.Parse(Console.ReadLine());

        //a
        int counter = 1;
        int[,] a = new int[size, size];
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
            {
                a[j, i] = counter;
                counter++;
            }

        //b
        counter = 1;
        int[,] b = new int[size, size];
        for (int i = 0; i < size; i++)
            if (i % 2 == 0)
                for (int j = 0; j < size; j++)
                {
                    b[j, i] = counter;
                    counter++;
                }
            else
                for (int j = size - 1; j >= 0; j--)
                {
                    b[j, i] = counter;
                    counter++;
                }

        //c
        counter = 1;
        int[,] c = new int[size, size];
        for (int i = size - 1; i >= 0; i--)
            for (int j = i; j < size; j++)
            {
                c[j, j - i] = counter;
                counter++;
            }
        for (int i = -1; i >= 1 - size; i--)
            for (int j = 0; j <= size + i - 1; j++)
            {
                c[j, j - i] = counter;
                counter++;
            }

        PrintMatrix(a, size);
        PrintMatrix(b, size);
        PrintMatrix(c, size);
    }
}
