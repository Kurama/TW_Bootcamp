using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day9_Serialization
{
    class Program
    {
        void serializeMethod(){
            string path = @"/Users/taj/Documents/Bootcamp/CSharp/src/File/File.txt";
            Student s = new Student(1,"Sakura");
            FileStream stream = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream,s);
            stream.Close();
            
            System.Console.WriteLine("File saved in " + path);
        }

        void deserializeMethod(){
            string path = @"/Users/taj/Documents/Bootcamp/CSharp/src/File/File.txt";
            FileStream stream = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(stream);
            
            System.Console.WriteLine("ID : " + s.id);
            System.Console.WriteLine("Name : " + s.name);
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.serializeMethod();
            obj.deserializeMethod();
        }
    }
}
