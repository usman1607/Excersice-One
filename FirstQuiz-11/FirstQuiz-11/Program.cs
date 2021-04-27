

//Question 11: Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.

using System;

namespace FirstQuiz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line prompt the user to enter the first number.
            Console.Write("Enter the first number: ");

            int a = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            if(a == b)
            {
                Console.WriteLine("The two integers are equal and the the triple of their sum is {0}", (a + b) * 3);
            }
            else
            {
                Console.WriteLine("The sum of the two integers is {0}", a + b);
            }
            
        }
    }
}
