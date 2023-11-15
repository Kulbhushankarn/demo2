using System;

class Person
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    
    public Person()
    {
        
        Name = "XYZ";
        Age = 30;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        
        Person person = new Person();

        
        Console.WriteLine("Default Attributes:");
        person.DisplayInfo();

       
        person.Name = "ABCD";
        person.Age = 25;

        
        Console.WriteLine("\nModified Attributes:");
        person.DisplayInfo();
    }
}

