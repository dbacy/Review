using System;
using System.Collections.Generic;
using System.Linq;

namespace Review
{
    class Program
    {
     

        static void Main(string[] args)
        {


            for (int i = 13; i <= 76; i++)
            {
                Console.WriteLine("the loop index is = " + i);
            }

            for (int i = 0; i<=50; i++)
            {
                Console.WriteLine("the loop index squared is: " + i);
            }

            for (int i = 21; i<=43; i++ )
            {

            }

            for (int i = -21; i <= 87; i++ )
            {

            }

            for (int i = 53; i >=27; i++)
            {
                Console.WriteLine(i);
            }





            //shift + alt + use mouse to select
            // list will dupe , set will not

            List<int> lNumbers = new List<int>(); //list 
            lNumbers.Add(5);
            lNumbers.Add(5);
            lNumbers.Add(5);
            lNumbers.Add(5);
            lNumbers.Add(5);
            lNumbers.Add(-5);


            HashSet<int> setNumbers = new HashSet<int>(lNumbers); // set



            

            List<string> userWords = new List<string>();
            string input;

            while (true)
            {
                input = utils.GetInput("Enter a word: ");
                if (input.Length == 0)  
                
                    break;
                userWords.Add(input);
                
            }
            

            string longString;
            string shortString;
            string earliestString;
            string latestString;
            longString = shortString = earliestString = latestString = userWords[0];
            foreach (var userWord in userWords )
            {
                if (userWord.Length < shortString.Length) shortString = userWord;          
                if (userWord.Length > longString.Length) longString = userWord;
                if (userWord.CompareTo(earliestString) <= 0) earliestString = userWord;   
                if (userWord.CompareTo(latestString) >= 0) longString = userWord;
            }

            Console.WriteLine();




            int[] numbers = { 7, 6, 3, 3, 6, 76, 3, 6, 8, 6, 3, 243, 5, 7 };
            //  Convert this string into an array of words
            string line = "Convert this string into an array of words";

            int largestNum = numbers.Max();
            string[] words = line.Split(" ");
            List<string> lwords = new List<string>(words);
            //string lastWord = lwords.Sort((early ,w) => early.CompareTo(w));
            foreach (var word in words)
            {
                if (word.EndsWith("g"))
                {
                    Console.WriteLine($"the word ({word})ends with (g)");
                }
            }
            int total = 0, lessThan50 = 0;
            foreach ( var num in numbers)
            {
                total += num;
                if (num < 50 )
                {
                    lessThan50 += num;
                }
            }
            Console.WriteLine($"the total of all numbers is {total}");
            Console.WriteLine($"the total of all numbers <50 is  {lessThan50}");
            Console.WriteLine($"the middle number of the arry is: {numbers[numbers.Length/2]}");




            string name = "derek luttrell bacy";
            
            



        }


    }
}
