using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGraph
{
    class Program
    {
        static CustomGraph g = new CustomGraph(new int[2, 2]);
        static void Main(string[] args)
        {
            g.AddEdges(0, 1);
            g.AddEdges(0, 0);
            //TreverseDFS(1);
            for (int i = 0; i < 2; i++)
            {
                if (!visited[i])
                {
                    TreverseDFS(i);
                }
            }

            Console.ReadLine();
        }

        static bool[] visited = new bool[2];

        static void TreverseDFS(int i)
        {
            if (!visited[i])
            {
                Console.WriteLine(i + 1);
                visited[i] = true;
                foreach (var v in g.GetSuccessors(i))
                {
                    TreverseDFS(v);
                }
            }
        }
    }
}
