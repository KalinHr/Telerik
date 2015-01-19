using System;

/*Write an expression that checks for given integer if its third digit from right-to-left is 7.*/

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isTrue = false;
            if ((number / 100) % 10 == 7)
                isTrue = true;
            Console.WriteLine(isTrue);
        }
    }
