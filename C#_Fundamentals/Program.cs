// See https://aka.ms/new-console-template for more information


namespace System;  
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person person1 = new Person("Alice", 34);
        person1.SayHello(); 
        
    }


}



public class Person
{
    public string Name { get; set; }
    public int Age {  get; set; }

    public Person(string name, int age) //constructor 
    {
        Name = name;
        Age = age; 
    }

    public void SayHello()
    {
        Console.WriteLine("Hello my name is " + Name);
    }
}