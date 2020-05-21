using Lab9__3_.List;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList<string> members = new CircularLinkedList<string>();
            string path = @"C:\Users\MSI\source\repos\Lab9 (3)\Lab9 (3)\List\Имена.txt";
            using (var fileRead = new StreamReader(path))
            {
                while (fileRead.Peek() > -1)
                {
                    members.Add(fileRead.ReadLine());
                }
            }
            foreach (string member in members)
            {
                Console.Write(member + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите человека с кого начать считалку?");
            string name = "";
            while (!members.Contains(name))
            {
                name = Console.ReadLine();
                if (!members.Contains(name))
                {
                    Console.WriteLine("Имя не найдено введите из списка:");
                    foreach (string member in members)
                    {
                        Console.Write(member + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Введите считалочку");
            string text = Console.ReadLine();
            string[] word = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            members.Swap(name);
            Сhoice(members, word.Length-1);

        }
        public static void Сhoice(CircularLinkedList<string> members, int Length)
        {
            int count = 0;
            foreach (string name in members)
            {
                if (count == Length)
                {
                    Console.WriteLine(name);
                }
                count++;
            }
        }
    }
}
