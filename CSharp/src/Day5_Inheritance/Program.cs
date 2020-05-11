using System;

namespace Day5_Inheritance
{
    class Branch{
        int BranchCode = 100;
        string BranchName = "Bangalore";
        public virtual void DisplayBranchDetails(){
            
            System.Console.WriteLine("The Branch code is : " + BranchCode);
            System.Console.WriteLine("The Branch name is : " + BranchName);
        }
    }
    class Employee : Branch{
        int EmployeeID = 201;
        string EmployeeName = "Joey";
        public void DisplayEmployeeData(){
            System.Console.WriteLine("Employee ID is : " + EmployeeID);
            System.Console.WriteLine("Employee Name is : " + EmployeeName);
        }
        public override void DisplayBranchDetails(){
            System.Console.WriteLine("The Branch name is Kolkata");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.DisplayBranchDetails();
            obj.DisplayEmployeeData();
            
        }
    }
}
