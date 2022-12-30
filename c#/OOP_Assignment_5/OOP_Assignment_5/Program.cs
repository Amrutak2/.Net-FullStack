using System;
using System.Collections;

namespace OOP_Assignment_5
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] id = new int[4];
            int[] id2 = new int[4];
            string[] names = new string[4];
            string[] names2 = new string[4];

            Console.WriteLine("Enter the elements of array id: ");
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(i + " ");
            }
            for (int i=0; i<id.Length;i++)
            {
                Console.Write("{0} ", id[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Enter the elements of array names: ");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Convert.ToString(Console.ReadLine());
                //Console.WriteLine(i + " ");
            }
            for (int i=0; i<names.Length; i++)
            {

                Console.Write("{0} ", names[i]);
            }
            int ch;
            Console.WriteLine("\n");
            do
            {
                Console.WriteLine("Enter your choice: 1.Copy 2.Sort 3.Clear 4.Reverse 5.Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Array.Copy(id, id2, id.Length);
                        Console.Write("Copied Array: ");
                        for(int i=0; i<id.Length; i++)
                        {
                            Console.Write(" {0} ", id2[i]);
                        }
                        Console.Write("\n");
                        Array.Copy(names, names2, names.Length);
                        Console.Write("Copied Array: ");
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.Write(" {0} ", names2[i]);
                        }
                        Console.Write("\n");
                        break;
                    case 2:
                        Array.Sort(id);
                        Console.Write("Sorted array: ");
                        foreach (int el in id)
                        //for (int i = 0; i < e; i++)
                        {
                            Console.Write("{0}", el);
                        }
                        Console.Write('\n');
                        Array.Sort(names);
                        Console.Write("Sorted Array: ");
                        foreach (string el in names)
                        //for(int el=0; el<e; el++)
                        {
                            Console.Write(" {0} ", el);
                        }

                        Console.Write('\n');
                        break;

                    case 3:
                        Array.Clear(id, 0, id.Length);
                        Console.Write("Result Array: ");
                        for(int i=0; i<id.Length; i++)
                        {
                            Console.Write(" {0} ", id[i]);
                        }
                        Console.Write("\n");
                        Array.Clear(names, 0, names.Length);
                        Console.Write("Result Array: ");
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.Write(" {0} ", names[i]);
                        }
                        Console.Write("\n");
                        break;
                       

                    case 4:
                        //Array.Reverse(id);

                        //foreach (int el in id)
                        //{
                        //    Console.Write("Reversed Array: " + el + " ");
                        //}
                        Array.Reverse(id);
                        Console.Write("Reversed Array: ");
                        foreach (int el in id)
                        {
                            Console.Write(" {0} ", el);
                        }

                        Console.Write('\n');

                        Array.Reverse(names);
                        Console.Write("Reversed Array: ");

                        foreach (string el in names)
                        {
                            Console.Write(" {0} ", el);
                        }

                        Console.Write('\n');
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (ch < 5);

        }
    }
}
