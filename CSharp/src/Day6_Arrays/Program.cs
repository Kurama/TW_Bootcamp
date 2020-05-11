using System;

namespace Day6_Arrays
{
    class Arrays{
        public void accessUsingForEach(int[] arr){
            System.Console.WriteLine("Values printed using foreach");
            foreach (int i in arr){
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }

        public void accessUsingForLoop(int[] arr){
            System.Console.WriteLine("Values printed using for loop");
            for(int i = 0; i <= arr.Length; i++){
                System.Console.Write(arr[i] + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[]{2,4,6,8,10};
            int[] arr2 = new int[]{1,3,5,7,9};
            Arrays obj = new Arrays();
            obj.accessUsingForEach(arr1);
            obj.accessUsingForLoop(arr2);
        }
    }
}
