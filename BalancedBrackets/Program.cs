using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "([])(){ } (())()()";

            Console.WriteLine($"is this string {str} balanced? {BalancedBrackets(str)}");
        }

        public static bool BalancedBrackets(string str)
        {
            // Write your code here.
            return false;
        }
    }
}
