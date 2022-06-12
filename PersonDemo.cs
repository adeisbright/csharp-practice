using System;
public class PersonDemo : Person, ISchool
{
    public double networth;
    public PersonDemo(string name, int age, double networth) :
    base(name, age)
    {
        this.networth = networth;
    }

    public void printSchoolName()
    {
        Console.WriteLine(this.getName());
        Console.WriteLine($"The class nae is {Person.className}");
    }
}