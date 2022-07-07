using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Tree37
{
    class Tree
    {
        public Node Root { get; set; }
        public void AddNode(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
                return;
            }
            var current = Root;
            if (value < current!.Value)
            {
                if (current.Left == null)
                {
                    current.Left = new Node(value);
                }
                else
                {
                    current = current.Left;
                    AddNode(value, current);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = new Node(value);
                }
                else
                {
                    current = current.Right;
                    AddNode(value, current);
                }
            }
        }

        private void AddNode(int value, Node current)
        {
            if (value < current!.Value)
            {
                if (current.Left == null)
                {
                    current.Left = new Node(value);
                }
                else
                {
                    current = current.Left;
                    AddNode(value, current);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = new Node(value);
                }
                else
                {
                    current = current.Right;
                    AddNode(value, current);
                }
            }
        }
        public void Transform()
        {
            if (Root != null)
            { 
                if (Root.Left != null)
                {
                    Transform(Root.Left);
                }
                if (Root.Right != null)
                {
                    Transform(Root.Right);
                }
            }
           
        }
        private void Transform(Node node)
        {
            if (node.ChildCount != 0)
            {
                node.Value--;
            }
            else 
            {
                node.Value++;
            }
            if (node.Left != null)
            {
                Transform(node.Left);
            }
            if (node.Right != null)
            {
                Transform(node.Right);
            }
        }
        public void Ssilka(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Print(Root, x, y);
            Console.ResetColor();
            Console.WriteLine("" + "\n");
        }
        public static int Print(Node node, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x, y + 1);
            Console.Write(node.Value);
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            int g = 0;
            var loc = y;

            if (node.Right != null)
            {

                Console.SetCursorPosition(x + 3, y + 3);
                Console.Write("\\");
                Console.SetCursorPosition(x + 2, y + 2);
                Console.Write("\\");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                y = Print(node.Right, x + 4, y + 3);
            }

            if (node.Left != null)
            {
                while (loc <= y)
                {
                    Console.SetCursorPosition(x - 1 - g, loc + 2);
                    Console.Write("/");
                    Console.SetCursorPosition(x - 1 - g, loc + 3);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    loc++;
                    g++;
                }
                y = Print(node.Left, x - 2 - g, y + 2);
            }
            return y;
        }
    }
}
