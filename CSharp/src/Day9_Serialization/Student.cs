using System;

namespace Day9_Serialization
{
    [Serializable]
    class Student{
        public int id;
        public string name;

        public Student(int id, string name){
        this.id = id;
        this.name = name;
        }
    }
}
