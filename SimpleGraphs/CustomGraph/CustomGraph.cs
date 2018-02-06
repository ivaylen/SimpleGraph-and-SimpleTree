using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGraph
{
    public class CustomGraph
    {
        private int[,] verticles;

        public CustomGraph(int[,] verticles)
        {
            this.verticles = verticles;
        }

        public void AddEdges(int i, int j)
        {
            this.verticles[i, j] = 1;
        }

        public void RemoveEdge(int i, int j)
        {
            this.verticles[i, j] = 0;
        }

        public bool HasEdge(int i, int j)
        {
            return this.verticles[i, j] == 1;
        }

        public List<int> GetSuccessors(int v)
        {
            List<int> n = new List<int>();
            for (int j = 0; j < this.verticles.GetLength(0); j++)
            {
                if (this.verticles[v, j] != 0)
                {
                    n.Add(j);
                }
            }

            return n;
        }
    }
}
