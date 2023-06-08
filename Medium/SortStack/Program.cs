using System;
using System.Collections.Generic;

namespace SortStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> stack = new List<int>() { -5, 2, -2, 4, 3, 1 };
            var sortedStack = SortStack(stack);
            Console.WriteLine($"The output is : {String.Join<int>(',',sortedStack)}");
        }

        //O(n^2) Time , O(n) Space
        public static List<int> SortStack(List<int> stack)
        {
            if (stack.Count == 0)
            {
                return stack;
            }
            var top = stack.POP();
            SortStack(stack);
            insertInSortedOrder(stack, top);

            return stack;
        }

        public static void insertInSortedOrder(List<int> stack, int value)
        {
            if (stack.Count == 0 || (stack.Peek() < value))
            {
                stack.Append(value);
                return;
            }
            var top = stack.POP();
            insertInSortedOrder(stack, value);
            stack.Append(top);
        }
    }
}



public static class Extensions
{
    public static T POP<T>(this List<T> l)
    {
        var listlength = l.Count;
        var deletedElement = l[listlength - 1];
        l.RemoveAt(listlength - 1);
        return deletedElement;
    }
    public static void Append<T>(this List<T> l, T el)
    {
        l.Add(el);
    }

    public static T Peek<T>(this List<T> l)
    {
        return l[l.Count - 1];
    }
}




