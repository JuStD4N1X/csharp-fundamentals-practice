using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    internal class Program
    {   
        class Person
        {
            private string name; //private IMPORTANT
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            /*public void SetName(string name)
            {   
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            }*/
            
           /* public void SetAge(int age)
            {
                this.age = age >= 0 && age < 150 ? age : -1; 
            }*/

            //public string GetName() { return this.name; }
            //public int GetAge() { return this.age; }

            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            public void SetAge(int age) => this.age = age >= 0 && age < 150 ? age : -1;

            public string GetName() => name;
            public int GetAge() => age;


            /*public string ReturnDetails()                   
            {
                return $"Name: {name}\nAge: {age}";
            }*/

            public string ReturnDetails() => $"Name: {name}\nAge: {age}";
        }

        static void Main(string[] args)
        {
            Person person = new Person("Aba", 23);
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine();

            //person.name = "Harry";    Doesn't work anymore because of private
            //person.age = 25;

            person.SetName("Harry");
            person.SetAge(25);
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}");

            Console.ReadLine();
        }
    }
}
