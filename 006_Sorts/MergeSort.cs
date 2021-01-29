using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Sorts
{
    class MergeSort
    {
        List<int> exlist;

        public MergeSort(int[] ex)
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

            exlist = Sort_Split(exlist);
            PrintResult();
        }

        List<int> Sort_Split(List<int> exlist)
        {
            if (exlist.Count <= 1)
                return exlist;
            else
            {
                List<int> answer = new List<int>();
                List<int> left = new List<int>();
                List<int> right = new List<int>();

                for(int i = 0; i < exlist.Count; i++)
                {
                    if (i < exlist.Count / 2)
                        left.Add(exlist[i]);
                    else
                        right.Add(exlist[i]);
                }
                return Sort_Merge(Sort_Split(left), Sort_Split(right));
            }
        }

        List<int> Sort_Merge(List<int> left, List<int> right)
        {
            int lidx = 0;
            int ridx = 0;
            List<int> answer = new List<int>();

            while(lidx != left.Count && ridx != right.Count)
            {
                if(left[lidx] < right[ridx])
                {
                    answer.Add(left[lidx]);
                    lidx++;
                }
                else
                {
                    answer.Add(right[ridx]);
                    ridx++;
                }
            }

            if(lidx != left.Count)
            {
                while(lidx != left.Count)
                {
                    answer.Add(left[lidx]);
                    lidx++;
                }
            }
            else
            {
                while(ridx != right.Count)
                {
                    answer.Add(right[ridx]);
                    ridx++;
                }
            }
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
