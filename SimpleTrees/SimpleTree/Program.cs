using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree
{
  class Program
  {

    static void Sum(params int[] numbers)
    {
      int sum = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        sum += numbers[i];
      }
      Console.WriteLine(sum);
    }
    static void Main(string[] args)
    {
      Sum(1);
      Sum(1, 2);
      Sum(1, 2, 3);
      List<int> a = new List<int>();
      SimpleTree<int> n = new SimpleTree<int>(5);
      n.root.childs.Add(new SimpleNode<int>(10));
      n.root.childs.Add(new SimpleNode<int>(15));
      n.root.childs.First().childs.Add(new SimpleNode<int>(100));
      n.root.childs.First().childs.First().childs.Add(new SimpleNode<int>(50));
      n.root.childs.First().childs.First().childs.Add(new SimpleNode<int>(150));

      n.root.childs
          .Where(x => x.Value == 15)
          .First()
          .childs
          .Add(new SimpleNode<int>(1500));
      n.DFS();
      Console.ReadLine();

    }
  }
}
