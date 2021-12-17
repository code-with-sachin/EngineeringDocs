//A static constructor is called automatically to initialize
// the class before the first instance is created or any static members are referenced.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class demo
    {
        static demo()
        {
            Console.WriteLine("Hello");
        }

        public demo()
        {
            Console.WriteLine("default constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo c = new demo();
            demo c1 = new demo();
            
            Console.WriteLine("Dhaval Vaja");

            Console.ReadKey(); 
        }
    }