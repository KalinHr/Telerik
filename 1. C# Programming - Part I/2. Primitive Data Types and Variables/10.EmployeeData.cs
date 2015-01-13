using System;

/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
   First name
   Last name
   Age (0...100)
   Gender (m or f)
   Personal ID number (e.g. 8306112507)
   Unique employee number (27560000…27569999)
  Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
  Use descriptive names. Print the data at the console.*/

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ico";
        string lastName = "Petrov";
        byte age = 22;
        char gender = 'm';
        long id = 8306112506;
        int number = 27560001;

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name:  " + lastName);
        Console.WriteLine("Age:        " + age);
        Console.WriteLine("Gender:     " + gender);
        Console.WriteLine("ID:         " + id);
        Console.WriteLine("Number:     " + number);
    }
}

