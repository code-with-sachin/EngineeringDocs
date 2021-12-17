using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_basic
{
    //its used to initialize class object
    //its always public
    //it never returns any value
    //there is always empty constructor present
    //it can be overloaded

    class Program
    {
        int a;

        Program() // This is empty constructor
        {
            Console.WriteLine("hello, this is empty constructor, which always initialize when u just create object of class.");
        }
        Program(int x) //This is parameterized constructor
        {
            a = x;
        }
        void display()
        {
            Console.WriteLine(" P : " + a); 
        }
        static void Main(string[] args)
        {
            //Empty constructor call
            Program p = new Program();
            //Parameterized constructor call
            Program q = new Program(10);
            q.display();                      
        }
    }
}
