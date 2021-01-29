using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestQueue();
            TestPriorityQueue();
        }

        static void TestPriorityQueue()
        {
            int[] Priority = new int[5] { 2, 5, 1, 4, 3 };
            string[] test = new string[5] { "피자", "짬뽕", "냉채족발", "라면", "크림빵" };

            Console.WriteLine("== Priority Queue 생성 ==");
            PriorityQueue testQ = new PriorityQueue(test[0], Priority[0]);
            Console.WriteLine("넣은 데이터: {0}, 우선 순위: {2}, 현재 데이터 수: {1}\n", test[0], testQ.Count, Priority[0]);

            Console.WriteLine("== 데이터 Enqueue 하고 우선순위에 따라 정렬 ==");
            for (int i = 1; i < test.Length; i++)
            {
                testQ.EnQ(test[i],Priority[i]);
                Console.WriteLine("넣은 데이터: {0}, 우선 순위: {2}, 현재 데이터 수: {1}", test[i], testQ.Count, Priority[i]);
            }
            Console.WriteLine();


            Console.WriteLine("== 데이터 Dequeue 하기(우선순위 순으로 뽑히는지 확인하기) ==");
            while (testQ.Count != 0)
            {
                int p;
                string result = testQ.DeQ(out p);
                Console.WriteLine("뺀 데이터: {0}, 뺀 데이터의 우선순위: {2}, 남아있는 데이터 수: {1}", result, testQ.Count, p);
            }

            Console.WriteLine("\n== 비어있는 큐 확인 ==");
            Console.WriteLine(testQ.DeQ());

        }

        static void TestQueue()
        {
            string[] test = new string[5] { "강아지", "고양이", "팽귄", "족제비", "사자" };

            Console.WriteLine("== Queue 생성 ==");
            Queue testQ = new Queue(test[0]);
            Console.WriteLine("넣은 데이터: {0}, 현재 데이터 수: {1}", test[0], testQ.Count);

            Console.WriteLine("== 데이터 Enqueue 하기 ==");
            for(int i = 1; i < test.Length; i++)
            {
                testQ.EnQ(test[i]);
                Console.WriteLine("넣은 데이터: {0}, 현재 데이터 수: {1}", test[i], testQ.Count);
            }
            testQ.PrintAllData();

            Console.WriteLine("\n== 데이터 Dequeue 하기 ==");
            while(testQ.Count != 0)
            {
                Console.WriteLine("뺀 데이터: {0}, 현재 데이터 수: {1}", testQ.DeQ(), testQ.Count);
            }

            Console.WriteLine("\n== 비어있는 큐 확인 ==");
            testQ.PrintAllData();
        }
    }
}
