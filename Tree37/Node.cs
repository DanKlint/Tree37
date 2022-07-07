using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree37
{
    class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public int ChildCount
        {
            get
            {
                int count = 0;

                if (Left != null) count++;
                if (Right != null) count++;

                return count;
            }
        }
    }
}
