using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ex = new int[7] { 1, 5, 2, 7, 3, 6, 4 };

            Heap myHeap = new Heap(ex[0]);

            // ex배열 요소 순서대로 넣기
            for(int i = 1; i < ex.Length; i++)
            {
                myHeap.Add(ex[i]);
            }

            // Pop되는 데이터는 항상 Heap의 최대값
            while(myHeap.count != 0)
            {
                Console.WriteLine("빼낸 데이터" + myHeap.Pop());
            }

            Console.WriteLine("== 비어있는 힙 확인");
            myHeap.Pop();

            Console.WriteLine();
        }
    }
}
