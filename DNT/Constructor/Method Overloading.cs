using System;
using System.Collections.Generic;
using System.Text;

namespace Method_overloading
{
    //method overloading is in same class
    //In method overriding, we can declare methods with same name, but the parameters are different.
    class Program
    {
        int a =10 , b = 20, c = 30;
        //c = 20;

        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int ans1, ans2;
            ans1 = p.add(10, 20);
            ans2 = p.add(10, 20, 30);
            Console.WriteLine(" Answer - 1  : " + ans1);
            Console.WriteLine(" Answer - 2  : " + ans2); 
        }
    }
}
