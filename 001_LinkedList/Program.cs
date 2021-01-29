using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = new string[5] { "강아지", "고양이", "펭귄", "족제비", "사자" };

            Console.WriteLine("==== LinkedList 생성 ====");
            LinkedListMng myLL = new LinkedListMng(test[0]);
            Console.WriteLine("넣은 데이터: {0}, 현재 데이터 수: {1}", test[0], myLL.theList.Count);

            Console.WriteLine("\n==== 나머지 데이터 삽입 후 전체 리스트 확인 ====");
            for(int i = 1; i < test.Length; i++)
            {
                myLL.AddData(test[i]);
            }
            myLL.PrintAllData();

            Console.WriteLine("\n==== 3번째 순서에 데이터 삽입 후 전체 리스트 확인 ====");
            myLL.InsertData("오리", 3);
            myLL.PrintAllData();

            Console.WriteLine("\n==== 특정 데이터 삭제 후 전체 리스트 확인 ====");
            myLL.DeleteData("고양이");
            myLL.PrintAllData();

            Console.WriteLine("\n==== 임의 데이터 리스트 존재여부 확인 ====");
            myLL.PrintAllData();
            myLL.Contain("고양이");
            myLL.Contain("펭귄");


        }
    }
}
