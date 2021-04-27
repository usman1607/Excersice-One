
//Question 6: Write a C# Sharp program that takes a number as input and print its multiplication table


using System;

namespace FirstQuiz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line prompt the user to enter the first number.
            Console.Write("Enter the number: ");

            int num = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            Console.WriteLine("Multiplication table of {0}:", num);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
            }

        }
    }
}
