using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_BFS_DFS
{
    class Program
    {
        /*
         예시 그래프 이미지: https://ifh.cc/v-z07XA6
        */

        static void Main(string[] args)
        {
            Console.WriteLine(" ===== 너비 우선 탐색 ===== ");
            BFS myBFS = new BFS();

            Console.WriteLine(" ===== 깊이 우선 탐색 ===== ");
            DFS myDFS = new DFS();
        }
    }
}
