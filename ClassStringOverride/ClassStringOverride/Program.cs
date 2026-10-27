using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStringOverride
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get => name;
                set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
            }

            public int Age
            {
                get => age;
                set => age = value >= 0 && value < 150 ? value : -1;

            }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            //public string ReturnDetails() => $"Name: {name}\nAge: {age}";

            public override string ToString()
            {
                return $"Name: {name}\nAge: {age}"; //Overriding ToString
            }

            public override bool Equals(object obj)
            {   if (obj is Person) 
                { 
                    Person person = obj as Person; //casting, without the if u can get run time error
                    return Name.Equals(person.Name) && Age == person.Age;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Aba", 25);
            Person test = new Person("Aba", 25);


            //Console.WriteLine(person); this now it works cuz override

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not the same");
            }

            Console.ReadLine();
        }
    }
}
