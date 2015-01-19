using System;

/*The gravitational field of the Moon is approximately 17% of that on the Earth.
  Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("weight = ");
        double weight = Convert.ToDouble(Console.ReadLine());
        double weightOnTheMoon = (weight / 100) * 17;
        Console.WriteLine("weight ot the moon = " + weightOnTheMoon);
    }
}
