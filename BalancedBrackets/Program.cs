using System;
using System.Collections.Generic;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "([])(){ } (())()()";

            str = "{[[[[({(}))]]]]}"; // test case 12 
            str = ")[]}"; // test case 14

            Console.WriteLine($"is this string {str} \nbalanced? {BalancedBrackets(str)}");
        }

        //Time = O(N), Space = O(N)
        public static bool BalancedBrackets(string str)
        {
            Stack<char> stackChars = new Stack<char>();
            var openingChars = new char[] { '(', '[', '{' };
            var closingChars = new char[] { ')', ']', '}' };
            //We can also defice a dictionary for matching characters instead of comparing indexes 
            foreach (var item in str)
            {
                if (Array.IndexOf(openingChars, item) >= 0)
                {
                    stackChars.Push(item);
                }
                else if (Array.IndexOf(closingChars, item) >= 0)
                {
                    if (stackChars.Count == 0)
                        return false;
                    var popedChar = stackChars.Pop();
                    if (Array.IndexOf(openingChars, popedChar) != Array.IndexOf(closingChars, item))
                    {
                        return false;
                    }
                }
            }

            return stackChars.Count == 0;
        }
    }
}
