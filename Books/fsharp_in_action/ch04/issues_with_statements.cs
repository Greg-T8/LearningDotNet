using System;

public void DescribeAge(int age)
{
    string ageDescription = null;
    var greeting = "Hello";
    if (age < 18)
    {
        ageDescription = "Child";
    }
    else if (age < 65)
    {
        greeting = "Adult";
    }
    Console.WriteLine($"{greeting}! You are a '{ageDescription}'.");
}

private static string GetDescription(int age)
{
    if (age < 18) return "Child!";
    else if (age < 65) return "Adult!";
    else return "OAP!";
}

public void DescribeAge(int age)
{
    var ageDescription = GetDescription(age);
    var greeting = "Hello";
    Console.WriteLine($"{greeting}! You are a '{ageDescriotion}'.");
}

public void DescribeAge(int age)
{
    string ageDescription = null;
    var greeting = "Hello";
    if (age < 18)
        ageDescription = "Child";
    else if (age < 65)
        greeting = "Adult";
    Console.WriteLine($"{greeting}! You are a '{ageDescription}'.");
}
