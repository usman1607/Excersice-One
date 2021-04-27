using System;

namespace FirstQuiz_12_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////
            //Question 12: Write a C# program to multiply corresponding elements of two arrays of integers.
            Console.WriteLine("Question 12 Answer:");

            int[] arr1 = { 4, 7, 8, 23, 76 };
            int[] arr2 = { 5, 3, 10, 2, 3 };
            int n;
            for(n = 0; n < arr1.Length; n++)
            {
                Console.Write(arr1[n] + " ");
            }
            Console.WriteLine("\nand");
            for (n = 0; n < arr2.Length; n++)
            {
                Console.Write(arr2[n] + " ");
            }

            Console.WriteLine("\nThe multiple of corresponding elements of the two arrays are: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] * arr2[i] + " ");
            }



            /////////////////////////////////////////////////////////////////
            ///Question 13: Write a C# program to find the longest word in a string.
            Console.WriteLine("\n \n Question 13 Answer:");

            //Prompt the user to write a sentence.
            Console.WriteLine("Please write a sentence: ");
            string str = Console.ReadLine();
            string[] strArr = str.Split(" ");

            string longest = strArr[0];                 // We assumed that the longest word is the first word in the sentence.
            for(int x = 1; x < strArr.Length; x++)
            {
                if(strArr[x].Length > longest.Length)
                {                                          //If the word at index x is longer than the former longest,
                    longest = strArr[x];                        //then the new longest is the word at index x.
                }
            }

            Console.WriteLine("The longest word is " + longest);




            /////////////////////////////////////////////////////////////////
            ///Question 14: Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
                //Example
                //Input - 15
                //Output - It is a multiple of 5 but not a mutiple of 7
                //Input - 11
                //Output - It is neither a multiple of 5 nor 7
                //Input – 35
                //Output - It is a multiple of both 5 and 7
            Console.WriteLine("\n \n Question 14 Answer:");

            //The line prompt the user to enter the number.
            Console.WriteLine("Please enter the positive integer number:");

            int intNum = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.
            if(intNum % 3 == 0 && intNum % 7 != 0)
            {
                Console.WriteLine("It is a multiple of 3 but not a multiple of 7");
            }
            else if (intNum % 3 != 0 && intNum % 7 == 0)
            {
                Console.WriteLine("It is a multiple of 7 but not a multiple of 3");
            }
            else if(intNum % 3 != 0 && intNum % 7 != 0)
            {
                Console.WriteLine("It is neither a multiple of 3 nor 7");
            }
            else
            {
                Console.WriteLine("It is multiple of both 3 and 7");
            }



            /////////////////////////////////////////////////////////////////
            ///Question 15: Write a C# program to find the largest and lowest values from three integer values.
            Console.WriteLine("\n \n Question 15 Answer");

            //The line prompt the user to enter the first number.
            Console.Write("Enter the first number: ");

            int a = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            Console.Write("Enter the second number :");
            int b = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            Console.Write("Enter the third number: ");
            int c = Convert.ToInt32(Console.ReadLine());    //Get the imput from user and convert it to integer.

            int lowest = a;
            int highest = a;
            if(b < lowest)
            {
                lowest = b;
                if(c < lowest)
                {
                    lowest = c;
                }
            }
            else
            {
                if(c < lowest)
                {
                    lowest = c;
                }
            }
            Console.WriteLine("The lowest is: " + lowest);

            if (b > highest)
            {
                highest = b;
                if (c > highest)
                {
                    highest = c;
                }
            }else
            {
                if(c > highest)
                {
                    highest = c;
                }
            }
            Console.WriteLine("The highest is: " + highest);





        }
    }
}
