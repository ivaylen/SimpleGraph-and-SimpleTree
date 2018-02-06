using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree
{
  public class SimpleNode<T>
  {
    public T Value { get; set; }
    public List<SimpleNode<T>> childs { get; set; }
    public SimpleNode(T val)
    {
      this.Value = val;
      //this.childs.Add(new SimpleNode<T>(default(T)));
      this.childs = new List<SimpleNode<T>>();
    }
  }
}
