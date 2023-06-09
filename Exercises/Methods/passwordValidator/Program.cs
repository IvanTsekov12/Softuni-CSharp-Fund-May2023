using System;
using System.Linq;
using System.Collections.Generic;

namespace passwordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsLongEnough(password) && AtLeastTwoDigits(password) && OnlyLettersAndNumbers(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!IsLongEnough(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!OnlyLettersAndNumbers(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!AtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool IsLongEnough(string password)
        {

            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool OnlyLettersAndNumbers(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        static bool AtLeastTwoDigits(string password)
        {
            int digitsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    digitsCounter++;
                }
            }

            if (digitsCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}