using System;
using System.Collections.Generic;
using System.Linq;

namespace SunsetViews
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test case 1, expected output = [1, 3, 6, 7]
            int[] buildings = new int[] { 3, 5, 4, 4, 3, 1, 3, 2 };
            string direction = "EAST";

            //Test case 2, expected output = [0, 1]
            buildings = new int[] { 3, 5, 4, 4, 3, 1, 3, 2 };
            direction = "WEST";

            Console.WriteLine($"The sunset views is : { String.Join<int>(',', SunsetViews(buildings, direction))}");
        }


        //Time O(N) , Space O(N)
        public static List<int> SunsetViews(int[] buildings, string direction)
        {
            Stack<int> resultStack = new Stack<int>();

            int startIdx = (direction == "EAST" ? 0 : buildings.Length - 1);
            int step = (direction == "EAST" ? 1 : -1);

            int idx = startIdx;
            while (idx >= 0 && idx < buildings.Length)
            {
                int buildingHeight = buildings[idx];
                while (resultStack.Count > 0 && buildings[resultStack.Peek()] <= buildingHeight)
                {
                    resultStack.Pop();
                }
                resultStack.Push(idx);

                idx += step;
            }


            List<int> result = resultStack.ToList();
            if (direction != "WEST")
                result.Reverse();
            return result;
        }

        #region MySolution--Time O(N) , Space O(N)
        ////Time O(N) , Space O(N)
        //public static List<int> SunsetViews(int[] buildings, string direction)
        //{
        //    List<int> result = new List<int>();
        //    int current = int.MinValue;
        //    if (direction == "EAST")
        //    {
        //        for (int i = buildings.Length - 1; i >= 0; i--)
        //        {
        //            if (current == int.MinValue)
        //            {
        //                current = buildings[i];
        //                result.Add(i);
        //            }
        //            else if (buildings[i] > current)
        //            {
        //                current = buildings[i];
        //                result.Add(i);
        //            }
        //        }
        //        result.Reverse();
        //    }
        //    else
        //    {
        //        for (int i = 0; i < buildings.Length; i++)
        //        {
        //            if (current == int.MinValue)
        //            {
        //                current = buildings[i];
        //                result.Add(i);
        //            }
        //            else if (buildings[i] > current)
        //            {
        //                current = buildings[i];
        //                result.Add(i);
        //            }
        //        }
        //    }

        //    return result;
        //}
        #endregion

    }
}
