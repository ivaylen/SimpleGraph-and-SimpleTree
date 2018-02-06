using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraph
{
    class Program
    {
        static int[,] graph = new int[5, 5]
            {
                { 0,1,0,1,0},
                { 0,0,0,1,0},
                { 0,1,0,0,0},
                { 0,0,1,0,0},
                { 0,1,1,0,0}
            };

        static int N = graph.GetLength(0);
        static int[] pred = new int[N];

        static bool[] isUsed = new bool[N];

        static void DFS(int i)
        {
            for (int j = 0; j < N; j++)
            {
                if (graph[i, j] != 0 && !isUsed[j])
                {
                    isUsed[j] = true;
                    DFS(j);
                }
            }

            Console.WriteLine(i + 1);
        }

        static int PrintPath(int j)
        {
            int count = 1;
            if (pred[j] > -1)
            {
                count += PrintPath(pred[j]);
            }

            Console.Write("{0} ", j + 1);

            return count;
        }

        static void Solve(int start, int end)
        {
            for (int i = 0; i < N; i++)
            {
                pred[i] = -1;
            }

            BFSWithPred(start);
            if (pred[end] > -1)
            {
                Console.WriteLine("Nameren e pat");
                Console.WriteLine("Daljinata e {0}", PrintPath(end));
            }
            else
            {
                Console.WriteLine("No Path");
            }
        }

        static void BFSWithPred(int i)
        {
            int currentVert, levelVertex, queueEnd;
            bool[] used = new bool[N];
            int[] queue = new int[N];

            queue[0] = i;
            used[i] = true;
            currentVert = 0;
            levelVertex = 1;
            queueEnd = 1;

            while (currentVert < queueEnd)
            {
                for (int p = currentVert; p < levelVertex; p++)
                {
                    Console.Write("{0} ", queue[p] + 1);
                    currentVert++;

                    for (int j = 0; j < N; j++)
                    {
                        if (graph[queue[p], j] == 1 && !used[j])
                        {
                            queue[queueEnd] = j;
                            queueEnd++;
                            used[j] = true;
                            pred[j] = queue[p];
                        }
                    }
                }

                Console.WriteLine();
                levelVertex = queueEnd;
            }
        }

        static void BFS(int i)
        {
            int currentVert, levelVertex, queueEnd;
            bool[] used = new bool[N];
            int[] queue = new int[N];

            queue[0] = i;
            used[i] = true;
            currentVert = 0;
            levelVertex = 1;
            queueEnd = 1;

            while (currentVert < queueEnd)
            {
                for (int p = currentVert; p < levelVertex; p++)
                {
                    Console.Write("{0} ", queue[p] + 1);
                    currentVert++;

                    for (int j = 0; j < N; j++)
                    {
                        if (graph[queue[p], j] == 1 && !used[j])
                        {
                            queue[queueEnd] = j;
                            queueEnd++;
                            used[j] = true;
                        }
                    }
                }

                Console.WriteLine();
                levelVertex = queueEnd;
            }
        }

        static void Main(string[] args)
        {
            //DFS(1 - 1);
            Solve(0, 1);
            Console.ReadLine();
        }
    }
}
