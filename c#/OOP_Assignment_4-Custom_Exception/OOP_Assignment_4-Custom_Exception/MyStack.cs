using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_Custom_Exception_
{
    public class StackException : Exception
    {
        public StackException(string message) : base(message) { }
    }
    public class MyStack : ICloneable
    {
        private int[] arr = new int[20];
        private int top = -1;
        private int size;

        public object Clone()
        {
            Console.WriteLine("Cloned Array");
            MyStack newStack = new MyStack
            {
                arr = this.arr,
                top = this.top,
                size = this.size
            };
            return newStack;
        }
        public int SIZE { get { return size; } set { this.size = arr.Length; } }

        public void push(int a)
        {
            try
            {
                if (top == arr.Length - 1)
                {
                    throw new StackException("Stack full Exception");
                }
                arr[++top] = a;
                Console.WriteLine($"Pushed {a} onto stack");
            }
            catch (StackException st)
            {
                Console.WriteLine(st);
            }
        }
        public void POP()
        {
            try
            {
                if (top == -1)
                {
                    throw new StackException("Stack Empty Exception");

                }
                Console.WriteLine($"{arr[top]} popped");
                arr[top--] = 0;
            }
            catch (StackException st)
            {
                Console.WriteLine(st);
            }
        }
        public void display()
        {
            Console.WriteLine("Printing Array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
