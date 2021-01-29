using System;
using System.Diagnostics;

namespace _006_Sorts
{
    class SelectionSort
    {
        int[] exArr;

        public SelectionSort(int[] ex)
        {
            exArr = ex;
            Console.Write("시작데이터 - ");
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

            Sort();
            PrintResult();
        }

        public void Sort()
        {
            for(int i = 0; i < exArr.Length; i++)
            {
                int minVal = exArr[i];
                int minId = i;
                bool isChange = false;
                for(int j = i + 1; j < exArr.Length; j++)
                {
                    if (minVal > exArr[j])
                    {
                        minVal = exArr[j];
                        minId = j;
                        isChange = true;
                    }
                }
                if(isChange)
                {
                    Swap(ref exArr[i], ref exArr[minId]);
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
