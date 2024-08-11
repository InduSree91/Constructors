using System;

namespace Constructor
{
    class Employee
    {
        public string Name;  

        public Employee()
        {
            Name = "Indu Sree";  // set the value for Name
        }

        static void Main(string[] args)
        {
            Employee e = new Employee();  // Create an object of the Employee Class

            Console.WriteLine(e.Name);  // Print the value of Name
        }
    }
}