using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStack();
        }

        static void TestStack()
        {
            string[] test = new string[5] { "축구", "농구", "야구", "배구", "족구" };

            Console.WriteLine("== Stack 생성 ==");
            Stack testStk = new Stack(test[0]);
            Console.WriteLine("넣은 데이터: {0}, 현재 데이터 수: {1}", test[0], testStk.Count);

            Console.WriteLine("== 데이터 Push 하기 ==");
            for (int i = 1; i < test.Length; i++)
            {
                testStk.Push(test[i]);
                Console.WriteLine("넣은 데이터: {0}, 현재 데이터 수: {1}", test[i], testStk.Count);
            }
            Console.WriteLine("\n== 전체 Stack 확인 ==");
            testStk.PrintAllData();

            Console.WriteLine("\n== 데이터 Pop 하기 ==");
            while (testStk.Count != 0)
            {
                Console.WriteLine("뺀 데이터: {0}, 현재 데이터 수: {1}", testStk.Pop(), testStk.Count);
            }
        }
    }
}
