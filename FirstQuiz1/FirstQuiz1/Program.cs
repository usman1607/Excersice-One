//Question: Write a C# Sharp program to print the result of dividing two numbers.


using System;

namespace FirstQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //The line prompt the user to enter the first number.
                Console.WriteLine("Enter the first number:");

                int a = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

                Console.WriteLine("Enter the second number:");
                int b = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.
       
                Console.WriteLine( (double) a / b);     // We convert the answer to double value from integer to ensure we get corret answer in case we have a fraction.

            }
            catch(DivideByZeroException e)      //Since we can not divide a number by 0, this will tell us if the user enter 0 as the second number.
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)            //Instead of a number, if the user enter letter or any other special character, the exception will tell us after which we can do anything.
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
