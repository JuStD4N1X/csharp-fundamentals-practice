using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    internal class Program
    {
        class Person
        {
            //public string Name {  get; set; } //AUTO IMPLEMENTATION better IF THERE IS NO LOGIC
            //public int Age { get; set; }

            private string name;                   
            private int age;                     

            public string Name                    
            {
                get => name; 
                set //(string value)
                {
                    name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
                }

            }

            public int Age                        
            {
                get => age;
                set => age = value >= 0 && value < 150 ? value : -1;

            }

            // public string Name { get => name; set => name = value; } ALTERNATIVE
            // public int Age { get => age; set => age = value; }


            public Person(string name, int age)
            {
               // this.name = name; They are useless now
               //this.age = age;

                Name = name;
                Age = age;
            }

            /* 
             public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
             public void SetAge(int age) => this.age = age >= 0 && age < 150 ? age : -1;
                                                                                            REPLACED BY FUNCS IN LINES 16 AND 27 OUTDATED
             public string GetName() => name;
             public int GetAge() => age;
            */

            public string ReturnDetails() => $"Name: {name}\nAge: {age}";
        }
        static void Main(string[] args)
        {
            Person person = new Person("Aba", 23);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Harry";
            person.Age = 25;

            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");

            Console.ReadLine();
        }


    }
}
