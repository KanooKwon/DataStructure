using System;
using System.Collections.Generic;
using System.Linq;

namespace _006_Sorts
{
    class QuickSort
    {
        List<int> exlist;

        public QuickSort(int[] ex)
        {
            exlist = ex.ToList();

            Console.Write("시작데이터 - ");
            for (int i = 0; i < exlist.Count; i++)
            {
                if (i != exlist.Count - 1)
                {
                    Console.Write(exlist[i] + ", ");
                }
                else
                {
                    Console.WriteLine(exlist[i]);
                }
            }

            exlist = Sort(exlist);
            PrintResult();
           
        }

        List<int> Sort(List<int> exlist)
        {
            if (exlist.Count <= 1)
                return exlist;

            List<int> answer = new List<int>();
            int mid = exlist.Count / 2;
            List<int> smallLeft = new List<int>();
            List<int> largeRight = new List<int>();

            for(int i = 0; i < exlist.Count; i++)
            {
                if(i != mid)
                {
                    if (exlist[i] < exlist[mid])
                        smallLeft.Add(exlist[i]);
                    else
                        largeRight.Add(exlist[i]);
                }
            }

            if (smallLeft.Count > 1)
                smallLeft = Sort(smallLeft);

            if (largeRight.Count > 1)
                largeRight = Sort(largeRight);

            answer.AddRange(smallLeft);
            answer.Add(exlist[mid]);
            answer.AddRange(largeRight);

            return answer;
        }

        public void PrintResult()
        {
            Console.Write("정렬 결과 데이터 - ");
            for (int i = 0; i < exlist.Count; i++)
            {
                if (i != exlist.Count - 1)
                {
                    Console.Write(exlist[i] + ", ");
                }
                else
                {
                    Console.WriteLine(exlist[i]);
                }
            }
        }

    }
}
