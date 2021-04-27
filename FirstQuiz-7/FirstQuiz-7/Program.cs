

//Question 7: Write a C# program and compute the sum of the digits of an integer

using System;

namespace FirstQuiz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 878768;
            //double count = Math.Floor(Math.Log10(n) + 1); 

            //Let assume the number is a 3 digit integer...
            

            int number;

            do
            {
                Console.Write("Please enter a number between 100 and 999:");       //The line prompt the user to enter the 3 digits number.

                number = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.
            } while (number < 100 || number > 999);         //This will check if the number is not a 3 digit number and prompt the user to enter another number if not...

            int firstDigit = number / 100;
            int remainder = number % 100;
            int secondDigit = remainder / 10;
            int lastDigit = remainder % 10;

            Console.WriteLine("The sum of digits of your number is: {0}", firstDigit + secondDigit + lastDigit);
        }
    }
}
