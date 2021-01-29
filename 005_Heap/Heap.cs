using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Heap
{
    class Node
    {
        public int Value;
        public int MyId;

        public Node(int v, int idx)
        {
            Value = v;
            MyId = idx;
        }

    }

    class Heap
    {
        List<Node> heapList = new List<Node>();
        public int count = 0;

        public Heap(int v)
        {
            Node ZeroNode = new Node(int.MinValue, 0);
            heapList.Add(ZeroNode);
            heapList.Add(new Node(v,1));
            count = 1;
        }

        public void Add(int num)
        {
            // 힙에 데이터가 하나도 없다면
            // (인덱싱 편의성을 위해 [0]을 사용하지 않으므로 count == 1이면 비어있는 힙)
            if (heapList.Count <= 1)
            {
                heapList.Add(new Node(num,1));
            }
            else
            {
                // 노드 생성
                Node newone = new Node(num, heapList.Count);
                heapList.Add(newone);

                // 부모노드 인덱스 위치에 있는 값과 비교
                while (newone.Value > heapList[newone.MyId / 2].Value &&
                        newone.MyId / 2 > 0)
                {
                    newone = Swap(newone.MyId / 2, newone.MyId);
                }
            }
            count++;
        }

        public int Pop()
        {
            if(count <= 0)
            {
                Console.WriteLine("해당 힙은 비어있습니다");
                return int.MinValue;
            }
            else
            {
                count--;
                // 리턴값은 무조건 맨처음 노드의 value
                int answer = heapList[1].Value;
                if (count > 0)
                {
                    heapList[1] = heapList[heapList.Count - 1];
                    heapList[1].MyId = 1;
                    heapList.RemoveAt(heapList.Count - 1);

                    ReBuild(1);
                }
                else
                {
                    heapList.RemoveAt(heapList.Count - 1);
                }
                return answer;
            }
        }


        public Node Swap(int p, int c)
        {
            Node temp = heapList[p];
            heapList[p] = heapList[c];
            heapList[p].MyId = p;
            heapList[c] = temp;
            heapList[c].MyId = c;
            return heapList[p];
        }

        public void ReBuild(int nowidx)
        {
            // 좌우 노드 둘다 있을때
            if(heapList.Count  > heapList[nowidx].MyId * 2 +1)
            {
                // 1. 좌우 노드 우선 비교
                int bigger = 0;
                int left = heapList[nowidx].MyId * 2;
                int right = heapList[nowidx].MyId * 2 + 1;

                if(heapList[left].Value > heapList[right].Value)
                    bigger = left;
                else
                    bigger = right;

                if(heapList[nowidx].Value < heapList[bigger].Value)
                {
                    Swap(nowidx, bigger);
                    ReBuild(bigger);
                }
                else
                {
                    return;
                }
            }
            // 왼쪽 노드만 있을때
            else if(heapList.Count > heapList[nowidx].MyId * 2)
            {
                int left = heapList[nowidx].MyId * 2;
                if (heapList[nowidx].Value < heapList[left].Value)
                {
                    Swap(nowidx, left);
                    ReBuild(left);
                }
                else
                {
                    return;
                }

            }
            // 자식 노드가 없을때
            else
            {
                return;
            }
        }
    }
}
