﻿using System;

/*Declare two string variables and assign them with Hello and World.
  Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
  Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/

class StringsAndObjects
{
    static void Main()
    {
        string s1 = "Hello";
        string s2 = "World";
        object o = s1 + " " + s2;
        string s3 = o.ToString();
    }
}

