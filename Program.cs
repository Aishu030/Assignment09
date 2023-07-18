using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ASSIGNMENT09

namespace Assignment09
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
         public static void Main(string[] args)
        {
            try
            {
                string name, email, password;
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter your email address:");
                email = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    throw new ValidationException("Name is required.");
                }

                else if (string.IsNullOrEmpty(email))
                {
                    throw new ValidationException("Email is required.");
                }

                else if (string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("Password is required.");
                }
                else if (name.Length < 6)
                {
                    throw new ValidationException("The length of the name should be minimum 6");
                }
                else if (password.Length < 8)
                {
                    throw new ValidationException("The length of the password should be minimum 8");
                }

                else
                {
                    Console.WriteLine("\n User registration is  successfull!" + "\n\n \t Details:");
                    Console.WriteLine($"\nName:  {name} \nEmail: {email} \nPassword: {password} \n");
                }
               
            }
            catch (ValidationException ve)
            {
                Console.WriteLine("Error !! in validation  " + ve.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            
            finally
            {
                Console.WriteLine("\n *********End of Registration process*******");

                Console.ReadKey();
            }
        }

    }

}



