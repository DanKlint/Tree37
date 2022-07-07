using System;
using System.Collections.Generic;

namespace Tree37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дан указатель P1 на корень непустого дерева. " +
                "Добавить 1 к значению каждого листа дерева и вычесть 1 из значения каждой внутренней вершины.");
            Console.WriteLine("Дерево:");
            //заполнение списка вершин
            var random = new Random();
            var size = random.Next(5, 10);
            var list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(10, 50));
            }
            
            var tree = new Tree();
            list.ForEach(x => tree.AddNode(x));
            tree.Ssilka(50, 5);
            Console.ResetColor();

            Console.WriteLine("\n" + "\n" + "\n" + "\n" + "Дерево после преобразования: ");
            tree.Transform();
            int coun = Console.CursorTop;
            tree.Ssilka(60, coun + 1);
            Console.ResetColor();
        }
    }
}
