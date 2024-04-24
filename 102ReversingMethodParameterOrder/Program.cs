using System;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string JobTitle { get; set; }

    public void DisplayEmployeeInfo(string name, int age, string jobTitle)
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Job Title: {jobTitle}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        // Calling the method with normal parameter order
        emp.DisplayEmployeeInfo("Sardar Mudassar Ali Khan", 30, "Software Engineer");

        // Reversing parameter order using named arguments
        emp.DisplayEmployeeInfo(age: 30, name: "Sardar Mudassar Ali Khan", jobTitle: "Software Engineer");
    }
}
