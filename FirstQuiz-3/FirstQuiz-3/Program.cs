

//Question 3: Write a C# program to print multiple of 7 from 1 to 1000. Prints one number per line.


using System;

namespace FirstQuiz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000; i++)      
            {
                if(i % 7 == 0)
                {                                       //When i divided by 7 remains 0, then i is a multiple of 7
                    Console.WriteLine(i);                   // so we print i.
                }
            }
            
        }
    }
}
