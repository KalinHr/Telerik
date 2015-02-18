using System;

/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
   several neighbour elements located on the same line, column or diagonal.
   Write a program that finds the longest sequence of equal strings in the matrix.
   Example:
   matrix
   ha	fifi ho	hi
   fo	ha	 hi	xx
   xxx	ho	 ha	xx
   result
   ha, ha, ha		

 */

class Program
{
    static void Main()
    {
        string[] forms = { "aa", "bb", "cc", "dd", "ee"};
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        Random random = new Random();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                matrix[i, j] = forms[random.Next(0, forms.Length)];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        string result = matrix[0, 0];
        int length = 0;
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                string currentString = matrix[i, j];
                int currentLength = 0;

                for (int k = 0; k < m - j; k++)
                {
                    if (currentString == matrix[i, k + j])
                    {
                        currentLength++;
                        if (currentLength > length)
                        {
                            result = currentString;
                            length = currentLength;
                        }
                    }
                    else
                        break;
                }
                currentLength = 0;
                for (int k = 0; k < n - i; k++)
                {
                    if (currentString == matrix[k + i, j])
                    {
                        currentLength++;
                        if (currentLength > length)
                        {
                            result = currentString;
                            length = currentLength;
                        }
                    }
                    else
                        break;
                }
                currentLength = 0;
                for (int k = 0; k < Math.Min(n - i, m - j); k++)
                {
                    if (currentString == matrix[k + i, k + j])
                    {
                        currentLength++;
                        if (currentLength > length)
                        {
                            result = currentString;
                            length = currentLength;
                        }
                    }
                    else
                        break;
                }
                currentLength = 0;
                for (int k = 0; k < Math.Min(n - i, j + 1); k++)
                {
                    if (currentString == matrix[k + i, j - k])
                    {
                        currentLength++;
                        if (currentLength > length)
                        {
                            result = currentString;
                            length = currentLength;
                        }
                    }
                    else
                        break;
                }
            }
        for (int i = 0; i < length - 1; i++)
            Console.Write(result + ", ");
        Console.WriteLine(result);
    }
}
