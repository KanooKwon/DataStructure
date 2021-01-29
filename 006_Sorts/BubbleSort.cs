using System;

namespace _006_Sorts
{
    class BubbleSort
    {
        int[] exArr;

        public BubbleSort(int[] ex)
        {
            exArr = ex;
            Console.Write("시작데이터 - ");
            for(int i = 0; i < exArr.Length; i++)
            {
                if(i != exArr.Length -1)
                {
                    Console.Write(exArr[i] + ", ");
                }
                else
                {
                    Console.WriteLine(exArr[i]);
                }
            }

            Sort();
            PrintResult();
        }

        public void Sort()
        {
            for(int i = 0; i < exArr.Length -1; i++)
            {
                // 이 for문이 한번 돌때마다 제일 큰값이 마지막으로 값
                for(int j = 0; j < exArr.Length -1 - i; j++)
                {
                    if (exArr[j] > exArr[j + 1])
                        Swap(ref exArr[j], ref exArr[j + 1]);
                }
            }
        }

        void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void PrintResult()
        {
            Console.Write("정렬 결과 데이터 - ");
            for (int i = 0; i < exArr.Length; i++)
            {
                if (i != exArr.Length - 1)
                {
                    Console.Write(exArr[i] + ", ");
                }
                else
                {
                    Console.WriteLine(exArr[i]);
                }
            }
        }

    }
}
