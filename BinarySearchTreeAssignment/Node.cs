using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeAssignment
{
    class Node
    {
        public Node(int value)
        {
            this.Value = value;
            Left = null;
            Right = null;
        }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public int Value { get; }

        public void Insert (int value)
        {
            if(value == Value)
            {
                return; // Do not insert duplicate values
            }

            if(value < Value)
            {
                if(Left == null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }

            if(value > Value)
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }

        public string Search(int value)
        {
            if(value < Value && Left != null)
            {
                return "LEFT, " + Left.Search(value);
            }
            else if(value > Value && Right != null)
            {
                return "RIGHT, " + Right.Search(value);
            }
            else if(value == Value)
            {
                return "";
            }

            return "VALUE NOT FOUND";
        }
    }
}
