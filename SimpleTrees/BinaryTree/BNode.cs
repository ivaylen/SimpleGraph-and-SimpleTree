using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
  public class BNode
  {
    public int Value { get; set; }
    public BNode Left { get; set; }
    public BNode Right { get; set; }

    public BNode(int value)
    {
      if (value == 0)
      {
        throw new Exception("Not allowed value");
      }

      this.Value = value;
    }
  }
}
