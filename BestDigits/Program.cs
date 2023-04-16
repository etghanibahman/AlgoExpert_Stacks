using System;
using System.Collections.Generic;

namespace BestDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "462839"; //6839
            int numDigits = 2;

            Console.WriteLine($"After removing {numDigits} number from {number}, we'll have {BestDigits(number, numDigits)}");
        }
        public static string BestDigits(string number, int numDigits)
        {
            Stack<int> ints = new Stack<int>();
            foreach (var item in number)
            {
                int currentNumber = int.Parse(item.ToString());
                while (ints.Count > 0 && numDigits > 0 && ints.Peek() < currentNumber)
                {
                    numDigits -= 1;
                    ints.Pop();
                }
                ints.Push(currentNumber);
            }

            while (numDigits > 0)
            {
                numDigits -= 1;
                ints.Pop();
            }

            string result = "";
            while (ints.Count > 0)
            {
                result = ints.Pop() + result;
            }

            return result;
        }

    }
}
