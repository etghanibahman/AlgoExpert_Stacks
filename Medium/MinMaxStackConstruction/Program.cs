using System;
using System.Collections.Generic;

namespace MinMaxStackConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
			MinMaxStack testCase1 = new MinMaxStack();

			testCase1.Push(5);
            Console.WriteLine($"getMin after pushing 5:{testCase1.GetMin()}");
			Console.WriteLine($"getMax after pushing 5:{testCase1.GetMax()}");
			Console.WriteLine($"peek after pushing 5:{testCase1.Peek()}");
			testCase1.Push(7);
			Console.WriteLine($"getMin after pushing 7:{testCase1.GetMin()}");
			Console.WriteLine($"getMax after pushing 7:{testCase1.GetMax()}");
			Console.WriteLine($"peek after pushing 7:{testCase1.Peek()}");
			testCase1.Push(2);
			Console.WriteLine($"getMin after pushing 2:{testCase1.GetMin()}");
			Console.WriteLine($"getMax after pushing 2:{testCase1.GetMax()}");
			Console.WriteLine($"peek after pushing 2:{testCase1.Peek()}");
		}

		public class MinMaxStack
		{
			Stack<int> mainStack = new Stack<int>();
			Stack<int> minStack = new Stack<int>();
			Stack<int> maxStack = new Stack<int>();

			public int Peek()
			{
				return mainStack.Peek();
			}

			public int Pop()
			{
				minStack.Pop();
				maxStack.Pop();
				return mainStack.Pop();
			}


			public void Push(int number)
			{
                if (mainStack.Count == 0)
                {
					mainStack.Push(number);
					maxStack.Push(number);
					minStack.Push(number);
                }
                else
                {
					int currMin = minStack.Peek();
					int currMax = maxStack.Peek();
					mainStack.Push(number);
                    if (number > currMax)
                    {
						maxStack.Push(number);
						minStack.Push(currMin);
                    }
                    else if (number < currMin)
                    {
						minStack.Push(number);
						maxStack.Push(currMax);
                    }
                    else
                    {
						minStack.Push(currMin);
						maxStack.Push(currMax);
					}
                }
			}


			public int GetMin()
			{
				return minStack.Peek();
			}


			public int GetMax()
			{
				return maxStack.Peek();
			}
		}
	}
}
