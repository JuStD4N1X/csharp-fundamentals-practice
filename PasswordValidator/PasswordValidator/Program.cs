using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPassword = false;
            bool isConfirmation = false;

            while (!isPassword)
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();


                if (!string.IsNullOrEmpty(password))
                {
                    isPassword = true;

                    while (!isConfirmation)
                    {
                        Console.Write("Enter your password again: ");
                        string passwordC = Console.ReadLine();

                        if (!string.IsNullOrEmpty(passwordC))
                        {
                            isConfirmation = true;

                            if (password.Equals(passwordC))
                            {
                                Console.WriteLine("Passwords match");
                            }
                            else
                            {
                                Console.WriteLine("Passwords do not match");
                                
                            }
                        }
                        else Console.WriteLine("Please enter a password confirmation.\n");
                    }

                    
                }
                else Console.WriteLine("Please enter a password.\n");
            }
            Console.ReadLine();

        }
    }
}
