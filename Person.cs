using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }//Field to pass The Constructor Value From The Main Instance
        public string LastName { get;  set; }
        public int Age { get;  set; }

        public Person(string name,string lastName,int age) { 
            Name= name;
            LastName= lastName;
            Age= age;
        }

        public void DisplayInfo()//Base Class Method
        {
            Console.WriteLine($"The name:{Name} Lastname:{LastName} Age:{Age}");
        }
    }

    public class Employee : Person//Create A class Employee and inherit from Person
    {
        public string Position { get; set; }//Extended fields for class Employee
        public int Salary { get; set; }
        public Employee(string name,string lastname,int age,string position,int salary):base(name,lastname,age){//extended Parameters while displaying from base class Person
            Position= position;
            Salary= salary;
        }
       
        public void DisplayEmployee()
        {
            DisplayInfo();//Called the Base Class Method
            Console.WriteLine($"Position:{Position},Salary:{Salary}");//Extended Method for Class Employee
        }

    }
}
