using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree
{
  public class SimpleTree<T>
  {
    public SimpleNode<T> root { get; set; }

    public SimpleTree(T value)
    {
      this.root = new SimpleNode<T>(value);
    }

    private void DFSHelper(SimpleNode<T> node, string spaces)
    {
      if (node == null)
      {
        return;
      }

      Console.WriteLine(spaces + node.Value.ToString());

      foreach (var c in node.childs)
      {
        DFSHelper(c, spaces + "-");
      }
    }

    public void DFS()
    {
      DFSHelper(this.root, "");
    }
  }
}
