using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var BT = new BinarySearchTree();
            BT.Insert(100);
            BT.Insert(58);
            BT.Insert(178);
            BT.Insert(122);
            BT.Insert(95);
            BT.Insert(29);
            BT.Insert(200);
            BT.Insert(45);
            Console.WriteLine("<" + BT.Search(2) + ">");
            Console.ReadLine();
        }
    }
}
