using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structures
{
    internal class Program
    {
        struct Person
        {   
            public string name;
            public int age;
            public int birthMonth;

            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }
        static void Main(string[] args)
        {
            /*Person person;

            person.name = "Aba";
            person.age = 23;
            person.birthMonth = 5;

            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");



            string newName = "";
            int newAge = 0;

            ReturnPerson(ref newAge, ref newName);
            Console.WriteLine($"{newName} - {newAge}");
            */

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");

            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birthmonth ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            /*Person person;

            person.name = name;
            person.age = age;
            person.birthMonth = birthMonth;

            return person;*/

            return new Person(name,age,birthMonth);
        }

        /*static void ReturnPerson(ref int age, ref string name)
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

        }*/
    }
}
