using System;
public class Person
{
    string name;
    int age;

    public static readonly string className = "Person";
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void greetPerson()
    {
        Console.WriteLine("Hello, " + this.name);
    }

    public int addNumber(int a, int b)
    {
        return a + b;
    }

    public string getName()
    {
        return this.name;
    }

    //Method overloading 
    // The compiler uses overloading resolution to dictate which 
    // method to call.  
    public static void sayAnything() => Console.WriteLine("I am saying anything");
    public static void sayAnything(string w) => Console.WriteLine(w);
    public static void printSkills(params string[] skills)
    {

        Console.WriteLine($"Your skills are : ");
        for (int i = 0; i < skills.Length; i++)
        {
            Console.WriteLine($"{skills[i]}");
        }
    }
}