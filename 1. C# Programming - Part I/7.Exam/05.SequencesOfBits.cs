using System;

class Program
{
    static void Main()
    {
        int  n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToString(Convert.ToUInt32(Console.ReadLine()), 2).PadLeft(30, '0');
        int maxZero = 0;
        int maxOne = 0;
        int currZero = 0;
        int currOne = 0;
        char c = '2';
        foreach (string element in arr)
        {
            int length = element.Length;
            for (int i = 0; i < length; i++)
            {
                if (element[i] == '0')
                {
                    if (c != element[i])
                    {
                        currOne = 0;
                        c = element[i];
                    }
                    currZero++;
                }
                else if(element[i] == '1')
                {
                    if (c != element[i])
                    {
                        currZero = 0;
                        c = element[i];
                    }
                    currOne++;
                }
                if (currZero > maxZero)
                    maxZero = currZero;
                if (currOne > maxOne)
                    maxOne = currOne;
            }
        }
        Console.WriteLine(maxOne);
        Console.WriteLine(maxZero);
    }
}
