using System;

namespace Day2_ObjAndClasses
{
    class Program
    {
        public int id;
        public string name;
        public float salary;

        public void addDetails(int ID, string Name, float Salary){
            id = ID;
            name = Name;
            salary = Salary;
        }

        public void displayDetails(){
            System.Console.WriteLine($"The jounin {name} with ID - {id} earns {salary}");
        }
    }

    class TestProgram{
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.addDetails(1,"Sakura", 1000);
            obj.displayDetails();
        }
    }
}
