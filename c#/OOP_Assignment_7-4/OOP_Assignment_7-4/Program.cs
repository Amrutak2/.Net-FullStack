using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_Assignment_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Github\.Net-FullStack\c#\OOP_Assignment_7-4\Output.txt";
            Employee emp = new Employee(301, "Amruta", 56000);
            FileStream stream = new FileStream(file, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine(" File created successfully -> " + file);


            FileStream stream1 = new FileStream(file, FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)bf.Deserialize(stream1);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);
            Console.WriteLine(objnew.salary);
        }
    }
}
