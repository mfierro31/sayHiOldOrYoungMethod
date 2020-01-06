using System;

namespace Csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 65);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            if (age >= 65)
            {
                Console.WriteLine("Hi, " + name + "! You're old!");
            } else if (age >= 40 && age < 65)
            {
                Console.WriteLine("Hi, " + name + "! You're gettin' up there!");
            } else if (age >= 20 && age < 40)
            {
                Console.WriteLine("Hi, " + name + "! You're a youngun'!");
            } else
            {
                Console.WriteLine("Hi, " + name + "! You're a baby!");
            }
            
        }
    }
}
