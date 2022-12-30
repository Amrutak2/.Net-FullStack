using System;

namespace Assignment_4_Custom_Exception_
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            MyStack s = new MyStack();
            do
            {
                Console.WriteLine("Enter choice");
                Console.WriteLine("1.Push 2.POP 3.Display 4.Clone 5.Exit");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter elements");
                        int n = Convert.ToInt32(Console.ReadLine());
                        s.push(n);
                        break;
                    case 2:
                        s.POP();
                        break;
                    case 3:
                        s.display();
                        break;
                    case 4:
                        MyStack newStack = s.Clone() as MyStack;
                        newStack.display();
                        break;
                    case 5: break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (ch < 5);
        }
    }
}
