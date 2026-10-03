using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        /*struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }*/

        class Person
        {
            public string name;
            public int age;

            public Person()
            {
                this.name = "noname";
                this.age = -1;
            }
            public Person(string name)
            {
                this.name = name;
            }

            public Person(int age)
            {
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name,age);
            Console.WriteLine();
            
            if (!string.IsNullOrEmpty(person.name))
            {
                Console.WriteLine(person.name);
            }

            if(person.age > -1)
            {
                Console.WriteLine(person.age);
            }


            Console.ReadLine();
        }
    }
}
