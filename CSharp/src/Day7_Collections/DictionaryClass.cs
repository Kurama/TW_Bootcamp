using System;
using System.Collections.Generic;

namespace Day7_Collections{

    class DictProgram{

        Dictionary<int,string> newDictionary = new Dictionary<int, string>();
        public void addElementToDict(){
            newDictionary.Add(1,"Jesse");
            newDictionary.Add(2,"Joey");
            newDictionary.Add(3,"Danny");
        }

        public void printDictionary(){
            System.Console.WriteLine("The newDictionary contents are : ");
            foreach (KeyValuePair<int,string> i in newDictionary){
                System.Console.WriteLine(i.Key + " " + i.Value);
            }
        }
    }
    class DictTest{
        static void Main(string[] args){
            DictProgram obj = new DictProgram();
            obj.addElementToDict();
            obj.printDictionary();
        }
    }
}