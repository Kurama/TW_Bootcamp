using System;

namespace Day3_Namespaces
{
    class Program
    {
        public void sayHi(){
            System.Console.WriteLine("Hello! This is Day3 Namespace");
        }

    }
}

namespace newOne{
    class Program{
        public void sayWelcome(){
            System.Console.WriteLine("Welcome! This is newOne Namespace");
        }
    }
}

namespace newTwo{
    class Program{
        public void letsCall(){
            System.Console.WriteLine("Again! This is newTwo Namespace");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.letsCall();
            Day3_Namespaces.Program obj1 = new Day3_Namespaces.Program();
            obj1.sayHi();
            newOne.Program obj2 = new newOne.Program();
            obj2.sayWelcome();
        }
    }
}
