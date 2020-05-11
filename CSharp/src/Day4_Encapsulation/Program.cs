using System;

namespace Day4_Encapsulation
{
    public class Encap{
        private int x;

        public int getX(){
            return x;
        }

        public void setX(int x){
            if(x > 0){
                this.x = x;
                System.Console.WriteLine("The current value of x is : " + x);
            }else{
                System.Console.WriteLine("The value is not positive");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Encap obj = new Encap();
            obj.setX(20);
            obj.getX();
            obj.setX(-1);
            obj.getX();
        }
    }
}
