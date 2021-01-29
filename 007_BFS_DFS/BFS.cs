using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_BFS_DFS
{
    class BFS
    {
        /*
         예시 그래프 이미지: https://ifh.cc/v-z07XA6
        */

        Dictionary<string, List<string>> exGraph = new Dictionary<string, List<string>>();

        public BFS()
        {
            CreateExGraph();
            PrintPath(DoBFS());
        }

        void CreateExGraph()
        {
            List<string> nodeA = new List<string> { "B", "C" };
            exGraph.Add("A", nodeA);
            List<string> nodeB = new List<string> { "D" };
            exGraph.Add("B", nodeB);
            List<string> nodeC = new List<string> { "G", "H", "I" };
            exGraph.Add("C", nodeC);
            List<string> nodeD = new List<string> { "E", "F" };
            exGraph.Add("D", nodeD);
            List<string> nodeE = new List<string>();
            exGraph.Add("E", nodeE);
            List<string> nodeF = new List<string>();
            exGraph.Add("F", nodeF);
            List<string> nodeG = new List<string>();
            exGraph.Add("G", nodeG);
            List<string> nodeH = new List<string>();
            exGraph.Add("H", nodeH);
            List<string> nodeI = new List<string> { "J" };
            exGraph.Add("I", nodeI);
            List<string> nodeJ = new List<string>();
            exGraph.Add("J", nodeJ);
        }

        List<string> DoBFS()
        {
            List<string> visited = new List<string>();
            List<string> need_Visited = new List<string>();

            string firstKey = exGraph.First().Key;
            visited.Add(firstKey);
            foreach (string s in exGraph[firstKey])
            {
                need_Visited.Add(s);
            }

            while (need_Visited.Count != 0)
            {
                string checkVisit = need_Visited[0];
                need_Visited.RemoveAt(0);
                if (!visited.Contains(checkVisit))
                {
                    visited.Add(checkVisit);
                    foreach (string s in exGraph[checkVisit])
                    {
                        need_Visited.Add(s);
                    }
                }
            }

            return visited;
        }

        void PrintPath(List<string> path)
        {
            Console.Write("검색 진행 순서: ");
            for (int i = 0; i < path.Count; i++)
            {
                if (i != path.Count - 1)
                {
                    Console.Write(path[i] + "->");
                }
                else
                {
                    Console.WriteLine(path[i]);
                }
            }
        }

    }
}
