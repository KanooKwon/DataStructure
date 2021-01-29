using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBST();

            
        }

        static void TestBST()
        {
            List<int> ex = new List<int>() { 5,2,8,1,3,9,4 };
            BST testTree = new BST(ex[0]);

            for (int i = 1; i < ex.Count; i++)
            {
                testTree.Add(ex[i]);
            }

            testTree.Delete(5);
            if (testTree.Search(4) != null)
            {
                Console.WriteLine("데이터를 찾았습니다");
            }
            else
            {
                Console.WriteLine("데이터가 트리에 없습니다");
            }
           

            Console.WriteLine();
        }
    }
}
