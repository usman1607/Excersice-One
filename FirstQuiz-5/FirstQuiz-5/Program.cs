

//Question 5: Write a C# program to reverse the words of a sentence.


using System;

namespace FirstQuiz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalSentence = "The name of the boy is John Alex";
            string[] words = originalSentence.Split(" ");                   //Split the sentence to string array of words.
            Array.Reverse(words);                                      //Reverse the words in the array.
            string newSentence = String.Join(" ", words);       //Form another sentence with the reversed words.

            Console.WriteLine(newSentence);
        }
    }
}
