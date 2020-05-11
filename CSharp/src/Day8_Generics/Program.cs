using System;

namespace Day8_Generics
{
    class MyGenericClass<T>{
        public T genericMemberVariable;
        public MyGenericClass(T value){
            genericMemberVariable = value;
        }
        public T genericMethod(T genericParameter){
            System.Console.WriteLine("Paramter Type : {0}, value : {1}",genericParameter.GetType(),genericParameter);
            System.Console.WriteLine("Parameter Type : {0}, value : {1}", genericMemberVariable.GetType(),genericMemberVariable);
            return genericParameter;
        }

    }

    class GenericType{
        public T[] CreateArray<T>(T firstElement, T secondElement){
            return new T[]{firstElement, secondElement};
        }

        public void TestmultiGenerics<T1, T2>(T1 t1, T2 t2){
            System.Console.WriteLine(t1.GetType());
            System.Console.WriteLine(t2.GetType());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> mgc = new MyGenericClass<int>(10);
            mgc.genericMethod(100);
            MyGenericClass<string> mgc1 = new MyGenericClass<string>("Test");
            mgc1.genericMethod("Test Again");

            GenericType arr = new GenericType();
            
            int[] arr1 = arr.CreateArray<int>(1,2);
            System.Console.WriteLine(arr1.Length + " " + arr1[0] + " " + arr1[1]);

            string[] arr2 = arr.CreateArray<string>("Jesse","Katsopolis");
            System.Console.WriteLine(arr2.Length + " " + arr2[0] + " " + arr2[1]);

            arr.TestmultiGenerics<int,string>(1,"You");
        }
    }
}
