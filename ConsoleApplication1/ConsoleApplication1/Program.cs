using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static IMenu menu=new Menu();
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                switch(input.ToLower())
                {
                    case "add":
                        Add();
                        break;
                    case "remove":
                        Remove();
                        break;
                    case "sort":
                        Sort();
                        break;
                    case "print":
                        menu.Print();
                        break;
                    case "save to file":
                        SaveToFile();
                        break;
                    case "load from file":
                        LoadFromFile();
                        break;


                    default:
                        Console.WriteLine("Command not found. Try again");
                        break;
                }
            }
        }
        private static void LoadFromFile()
        {
            var result = menu.LoadFromFile();
            Console.WriteLine(result);
        }
        private static void SaveToFile()
        {
           var result =  menu.SaveToFile();
            Console.WriteLine(result);
        }
        private static void Sort()
        {
            Console.WriteLine("Input sortExpression");
            var se = Console.ReadLine();
            var result = menu.Sort(se);
            Console.WriteLine(result);
        }
        private static void Remove()
        {
            Console.WriteLine("Input name to remove:");
            string name = Console.ReadLine();
            var result = menu.Remove( name );
            Console.WriteLine(result);
        }
        private static void Add()
        {
            Console.WriteLine("Input name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input phone:");
            string phone = Console.ReadLine();
            Console.WriteLine("Input address");
            string address = Console.ReadLine();
            var result = menu.Add(new People() { Name = name, Phone = phone, Address = address });
            Console.WriteLine(result);
            
        }
    }
}
