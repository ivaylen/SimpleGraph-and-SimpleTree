using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
  public class BTree
  {
    public BNode root { get; set; }

    public BTree(int value)
    {
      this.root = new BNode(value);
    }

    public void Preorder()
    {
      PrintPreorder(this.root, "");
    }

    private void PrintPreorder(BNode node, string space)
    {
      if (node == null)
      {
        return;
      }

      ////Inorder 
      PrintPreorder(node.Left, space + "-");
      Console.WriteLine(space + node.Value);
      PrintPreorder(node.Right, space + "-");

      ////Preorder
      //Console.WriteLine(space + node.Value);
      //PrintPreorder(node.Left, space + " ");
      //PrintPreorder(node.Right, space + " ");

      ////Postorder
      //PrintPreorder(node.Left, space + " ");
      //PrintPreorder(node.Right, space + " ");
      //Console.WriteLine(space + node.Value);
    }

    public void Add(int value)
    {
      SearchHelper(this.root, value, new BNode(value));
    }

    public void Delete(int value)
    {
      this.root = DeleteHelper(this.root, value);
    }

    private BNode DeleteHelper(BNode node, int value)
    {
      if (node == null)
      {
        return null;
      }

      if (node.Value == value)
      {
        //0 childs
        if (node.Left == null && node.Right == null)
        {
          return null;
        }

        //2 childs
        if (node.Left != null && node.Right != null)
        {
          //find bug
          BNode t = node;//c
          node = node.Left;//a
          node.Right = t.Right;//b
          
          return node;
        }

        //1 child
        if (node.Left != null)
        {
          return node.Left;
        }

        //1 child
        if (node.Right != null)
        {
          return node.Right;
        }
      }

      if (value > node.Value)
      {
        node.Right = DeleteHelper(node.Right, value);
      }

      if (value < node.Value)
      {
        node.Left = DeleteHelper(node.Left, value);
      }

      return node;
    }

    public BNode Search(int value)
    {
      return SearchHelper(this.root, value);
    }

    private BNode SearchHelper(BNode node, int value, BNode insertion = null)
    {
      if (node == null)
      {
        return null;
      }

      if (node.Value == value)
      {
        return node;
      }

      if (value > node.Value)
      {
        if (insertion != null && node.Right == null)
        {
          node.Right = insertion;
          return node;
        }

        return SearchHelper(node.Right, value, insertion);
      }

      if (insertion != null && node.Left == null)
      {
        node.Left = insertion;
        return node;
      }

      return SearchHelper(node.Left, value, insertion);
    }


  }
}
