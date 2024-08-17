using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static public void show()
        {

            A a = new A(), b = new B(), c = new C();
            I ia = new A(), ib = new B(), ic = new C();
            Console.WriteLine($"{a.P},{b.P},{c.P},{ia.P},{ib.P},{ic.P},");
        }
        interface I
        {
            int P { get; }
        }

        class A : I
        {
            public virtual int P => 1;
        }

        class B : A
        {
            public override int P => 2;
        }

        class C : A, I
        {
           public int P => 3;
        }
        static void Main(string[] args)
        {
            show();
        }

        public static int startIndex(int[] arr)
        {
            int minLength = 0;
            int i = 0;
            int startIndex = 0;

            while (i < arr.GetLength(0) - 1)
            {
                int len = 1;
                while (i < arr.GetLength(0) - 1 && arr[i] == arr[i + 1])
                {
                    len++;
                    i++;
                }
                if (len > minLength)
                {
                    startIndex = i - len + 1;
                    minLength = len;
                }
                i++;
            }
            return startIndex;
            /*   if(minLength>=2){
                   return startIndex;
               }
               else{return -1;}*/
        }


    }


    public static class primeoooo
    {
        public static bool IsPrime(this int a) {
            
            bool prost = true;

            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            return prost;
        }
    }
}
