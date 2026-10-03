using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*const int vat = 20;
            const double percentVAT = vat / 100D; !!!!!!! zamiana manualna z D mega ważna

            Console.WriteLine(vat);
            Console.WriteLine(2500 * percentVAT);

            Console.ReadLine();
            */

            string name = "Daniel";
            string number = "0123456789"; // jak dasz int to 0 ucieka, JAK DASZ VAR TO DZIAŁA XD
            int age = 20;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            Console.ReadLine();


        }
    }
}
