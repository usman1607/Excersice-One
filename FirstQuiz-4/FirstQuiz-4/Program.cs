

//Question 4: Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing
    //of two numbers which will be entered by the user. Create a method for each operation.


using System;

namespace FirstQuiz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line prompt the user to enter the first number.
            Console.WriteLine("Enter the first number:");

            int a = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            Console.WriteLine("Sum of the two numbers is {0}", add(a,b));

            Program program = new Program();    //If a method/function is not a static method, it must be instantiated before it can be called.
            Console.WriteLine("Second number subtracted from first numbers is {0}", program.subtract(a, b));

            Console.WriteLine("Product of the two numbers is {0}", multiply(a, b));

            Console.WriteLine("First number divided by second numbers is {0}", divide(a, b));
        }

        static int add(int x, int y)
        {
            return x + y;
        }

        int subtract(int x, int y)
        {
            return x - y;
        }

        static int multiply(int x, int y)
        {
            return x * y;
        }

        static double divide(int x, int y)
        {
            return (double) x / y;
        }
    }
}
