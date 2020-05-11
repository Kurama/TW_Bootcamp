using System;
using System.Collections.Generic;


namespace Day7_Collections
{
    class ListProgram{
        List<int> listInt = new List<int>();
        List<string> listStr = new List<string>(){"Naruto", "Hokage 7"};

        public void addToList(){
            listInt.Add(10);
            listInt.Add(20);
            listInt.Add(30);
        }

        public void printIntList(){
            System.Console.WriteLine("the current elements in the Int list is : ");
            foreach (var i in listInt){
                System.Console.WriteLine(i);
            }
        }

        public void removeElement(){
            listInt.RemoveAt(2);
            System.Console.WriteLine("Updated list is as below : ");
            printIntList();
        }

        public void printStrList(){
            var length = listStr.Count;
            System.Console.WriteLine("The current elements in the Str list is : ");
            for( int i = 0; i <= length; i++){
                System.Console.WriteLine(listStr[i]);
            }
        }
    }
    class Program
    {
        /*static void Main(string[] args)
        {
            ListProgram obj = new ListProgram();
            obj.addToList();
            obj.printIntList();
            obj.removeElement();
            obj.printStrList(); 
        }*/
    }
}
