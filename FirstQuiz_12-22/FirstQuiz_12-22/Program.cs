using System;

namespace FirstQuiz_12_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////
            //Question 12: Write a C# program to multiply corresponding elements of two arrays of integers.

            int[] arr1 = { 4, 7, 8, 23, 76 };
            int[] arr2 = { 5, 3, 10, 2, 3 };

            Console.WriteLine("The multiple of corresponding elements of the two arrays are: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] * arr2[i] + " ");
            }




            /////////////////////////////////////////////////////////////////
            ///Question 13: Write a C# program to find the longest word in a string.
            

        }
    }
}
