using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 버블 정렬
            Console.WriteLine("=========== 버블 정렬 ===========");
            int[] bubbleData = { 128, 52, 32, 74, 654, 12, 1, 500, 3 };
            BubbleSort myBubble = new BubbleSort(bubbleData);
            #endregion

            #region 선택 정렬
            Console.WriteLine("=========== 선택 정렬 ===========");
            int[] selectionData = { 128, 52, 32, 74, 654, 12, 1, 500, 3 };
            SelectionSort mySelection = new SelectionSort(selectionData);
            #endregion

            #region 삽입정렬
            Console.WriteLine("=========== 삽입 정렬 ===========");
            int[] InsertData = { 128, 52, 32, 74, 654, 12, 1, 500, 3 };
            InsertSort myInsert = new InsertSort(InsertData);
            #endregion

            #region 퀵정렬
            Console.WriteLine("=========== 퀵 정렬 ===========");
            int[] quickData = { 128, 52, 32, 74, 654, 12, 1, 500, 3 };
            QuickSort myQucik = new QuickSort(quickData);
            #endregion

            #region 병합정렬
            Console.WriteLine("=========== 병합 정렬 ===========");
            int[] mergeData = { 128, 52, 32, 74, 654, 12, 1, 500, 3 };
            MergeSort myMerge = new MergeSort(mergeData);
            #endregion

        }
    }
}
