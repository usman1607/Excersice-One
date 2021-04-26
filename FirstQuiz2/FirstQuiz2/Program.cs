

//Question 2: Write a C# Sharp program to swap two numbers

using System;

namespace FirstQuiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line prompt the user to enter the first number.
            Console.WriteLine("Enter the first number for num1:");

            int num1 = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            Console.WriteLine("Enter the second number for num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            int temp = num1;               // Keeping the value of num1 in temp.
            num1 = num2;                      // Swapping the value of num2 for num1.
            num2 = temp;                            //Value of num1 is assigned to num2 from temp.

            Console.WriteLine("Now, num1 is now {0} and num2 is now {1}", num1, num2);
        }
    }
}
