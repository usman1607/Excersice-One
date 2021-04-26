using System;

namespace FirstQuiz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveChar("International", 6));
        }

        static string RemoveChar(string word, int x)
        {
            return word.Remove(x, 1);   //Remove character at index x alone from word.
                                                //You can parse 3 in place of 1 to remove 3 character from index at x.
        }
    }
}
