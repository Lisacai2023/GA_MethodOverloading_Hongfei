using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading_Hongfei
{
    public class Employee
    {
        //Add the method to take the name only
        public void AddEmployee(string name)
        {
            Console.WriteLine($"Added employee:{name}");
        }

        //Method overloading to add method with name and age
        public void AddEmployee(string name,int age)
        {
            Console.WriteLine($"Added employee:{name}, age: {age}");
        }
        //Method overloading; method with name, age and department
        public void AddEmployee(string name, int age, string department)
        {
            Console.WriteLine($"Added employee:{name}, age: {age}, department: {department}");
        }

    }

}
