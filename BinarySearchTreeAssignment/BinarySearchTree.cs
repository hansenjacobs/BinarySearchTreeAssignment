using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeAssignment
{
    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
            Count = 0;
        }

        public int Count { get; private set; }

        public bool IsEmpty
        {
            get { return root == null; }
        }

        public void Insert(int value)
        {
            if (!IsEmpty)
            {
                root.Insert(value);
                Count++;
            }
            else
            {
                root = new Node(value);
                Count++;
            }
        }

        public string Search(int value)
        {
            string results = "ROOT, " + root.Search(value);

            if(results.Contains("VALUE NOT FOUND"))
            {
                results = "VALUE NOT FOUND  ";
            }

            return results.Substring(0, results.Length - 2);
        }
    }
}
