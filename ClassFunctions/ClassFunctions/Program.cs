using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()                   //3
            {
                return $"Name: {name}\nAge: {age}";
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Aba", 23);

            //Console.WriteLine($"Name: {person.name}");                     1
            //Console.WriteLine(ReturnDetails(person.name, person.age));     1 

            //Console.WriteLine(ReturnDetails(person));             2

            Console.WriteLine(person.ReturnDetails());        //3

            Console.ReadLine();
        }

       /* static string ReturnDetails(string name, int age)                  1    
        {
            return $"Name: {name}";
        }*/

       /* static string ReturnDetails(Person person)                2
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }*/
    }
}
