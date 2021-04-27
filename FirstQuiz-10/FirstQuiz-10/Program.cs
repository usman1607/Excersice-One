

//Question 10: Write a C# program to create a new string from a given string where the first and last characters will change their positions.

using System;

namespace FirstQuiz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line prompt the user to enter a string.
            Console.Write("Please enter a string: ");

            string word = Console.ReadLine();    //Get the imput from user.

            char[] array = word.ToCharArray();

            char i = word[0];       //Just declear a temporary character to switch the value of first and the last index.
            array[0] = word[word.Length - 1];
            array[word.Length - 1] = i;
            string newWord = new string(array);
            Console.WriteLine("The new string is {0}", newWord);
        }
    }
}
