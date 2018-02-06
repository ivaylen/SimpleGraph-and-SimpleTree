using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
  class Program
  {
    static void Main(string[] args)
    {

      BTree tree = new BTree(5);
      tree.Add(3);
      tree.Add(1);
      tree.Add(7);
      tree.Add(6);
      tree.Add(99);
      tree.Add(50);
      tree.Delete(6);
      tree.Preorder();

      //tree.root.Left = new BNode(10);
      //tree.root.Right = new BNode(15);
      //tree.root.Right.Right = new BNode(17);
      //Console.WriteLine(tree.Search(21).Value);

      Console.Read();
    }
  }
}
