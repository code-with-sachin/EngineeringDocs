/*The constructor which creates an object by copying variables from another object is called a copy 
constructor. 
The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.*/

using System;
namespace copyConstractor
{
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)   // declaring Copy constructor.
        {
            name = emp.name;
            age = emp.age;
        }
        public employee(string name, int age)  // Instance constructor.
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get details of employee
        {
            get
            {
                return  " The age of " + name +" is "+ age.ToString();
            }
        }
    }
    class empdetail
    {
        static void Main()
        {
            employee emp1 = new employee("Dhaval", 23);  
            employee emp2 = new employee(emp1);          
            Console.WriteLine(emp2.Details);
            Console.ReadLine();
        }
    }
}