using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 0, 1, 3, 77, 137, 343, 7, 13, 21, 37, 73 };
            string[] flavors = { "lemon", "lime", "vanilla", "rocky road", "chocolate", "butter pecan" };



            var max = luckyNumbers.Max();
            var greaterThan100 = luckyNumbers.Where(n => n > 100);
            Console.WriteLine(greaterThan100);
            var adverage = luckyNumbers.Average();
            var order = luckyNumbers.Distinct().OrderBy(n => n);


            var startWithL = flavors.Where(a => a.StartsWith("l"));
           var hasL = flavors.Contains("l");
            var alphabetically = flavors.OrderBy(n => n);
            var containMocoa = flavors.Contains("mocoa");


            int sizeOfTree = utils.GetNumber("Enter numbers from 1 - 10");
            for (int i =0; i<sizeOfTree; i++)
            {
                for (int j=0; j<sizeOfTree - i; j++)
                {
                    Console.Write(" ");
                }
                for ( int k =0; k<i*2-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            


        }
    }
}
