

//Question 8: Write a C# program to convert from Celsius degrees to Kelvin and Fahrenheit. C



using System;

namespace FirstQuiz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line prompt the user to enter the Temperature in Celsius degrees.
            Console.Write("Please enter the temperature in Celsius Degrees: ");

            int celsius = Convert.ToInt32(Console.ReadLine());    //Get the celsius from user.

            //Kelvin = Celsius + 273    Formular to convert celsius to kelvin.
            //Fahrenheit = Celsius * 18 / 10 + 32     formular to convert from celsius to Fahrenheit.
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}
