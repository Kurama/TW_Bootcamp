using System;

namespace Day1_MyFirstProject
{
    class Program
    {
        public int age;
        public string name;
    }

    class TestProgram{
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.age = 17;
            obj.name = "Naruto Uzumaki";

            System.Console.WriteLine("Name of the Ninja is : " + obj.name);
            System.Console.WriteLine("Age of the Ninja is : " + obj.age);

        }
    }
}
