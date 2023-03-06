using System;
using System.Collections.Generic;

namespace SunsetViews
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] buildings = new int[] { 3, 5, 4, 4, 3, 1, 3, 2 };
            string direction = "EAST";
            Console.WriteLine($"The sunset views is : { String.Join<int>(',', SunsetViews(buildings,direction))}");
        }

        //Time O(N) , Space O(N)
        public static List<int> SunsetViews(int[] buildings, string direction)
        {
            // Write your code here.
            return new List<int>();
        }
    }
}
