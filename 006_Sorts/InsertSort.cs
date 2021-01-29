using System;

namespace _006_Sorts
{
    class InsertSort
    {
        int[] exArr;

        public InsertSort(int[] ex)
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

        void Sort()
        {
            for(int i = 1; i < exArr.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if(exArr[j] < exArr[j-1])
                    {
                        Swap(ref exArr[j], ref exArr[j - 1]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        void PrintResult()
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
