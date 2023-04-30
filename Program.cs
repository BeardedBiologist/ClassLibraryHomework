using System;
using PersonLibrary;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.Age = 30;

            person.SayHello();

            Console.ReadKey();
        }
    }
}