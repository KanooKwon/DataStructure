using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Queue
{
    class Node
    {
        public string value;
        public Node back;

        public Node(string v)
        {
            value = v;
        }
    }

    class Queue
    {
        public Node head;
        public int Count;

        public Queue(string s)
        {
            head = new Node(s);
            Count++;
        }

        public void EnQ(string s)
        {
            if(Count == 0)
            {
                head = new Node(s);
                Count++;
            }
            else
            {
                Node data = head;
                while (data.back != null)
                {
                    data = data.back;
                }

                data.back = new Node(s);
                Count++;
            }
        }

        public string DeQ()
        {
            if (Count == 0)
            {
                return "해당 큐는 비었습니다";
            }
            else
            {
                string answer = head.value;

                head = head.back;
                Count--;

                return answer;
            }
        }

        public string Peek()
        {
            return head.value;
        }

        public void PrintAllData()
        {
            if(Count != 0)
            {
                Node data = head;
                while (data != null)
                {
                    Console.WriteLine(data.value);
                    data = data.back;
                }
            }
            else
            {
                Console.WriteLine("해당 큐는 비었습니다");
                return;
            }
            
        }
    }

    class priNode
    {
        public string value;
        public priNode back;
        public priNode front;
        public int Pri;

        public priNode(string v, int p)
        {
            value = v;
            Pri = p;
        }
    }

    class PriorityQueue
    {
        public priNode head;
        public int Count;
        

        public PriorityQueue(string v, int p)
        {
            head = new priNode(v, p);
            Count = 1;
        }

        public void EnQ(string v, int p)
        {
            priNode newone = new priNode(v, p);
            priNode data = head;

            while(data.back != null)
            {
                if(data.Pri > newone.Pri)
                {
                    Count++;
                    if (data == head)
                    {
                        newone.back = data;
                        data.front = newone;
                        head = newone;
                    }
                    else
                    {
                        data.front.back = newone;
                        newone.front = data.front;
                        newone.back = data;
                        data.front = newone;
                    }
                    return;
                }
                else
                {
                    data = data.back;
                }
            }

            if (data.Pri > newone.Pri)
            {
                Count++;
                if (data == head)
                {
                    newone.back = data;
                    data.front = newone;
                    newone = head;
                }
                else
                {
                    data.front.back = newone;
                    newone.front = data.front;
                    newone.back = data;
                    data.front = newone;
                }
                return;
            }
            else
            {
                Count++;
                data.back = newone;
                newone.front = data;
            }
        }

        public string DeQ(out int p)
        {
            if (Count == 0)
            {
                p = 0;
                return "해당 큐는 비었습니다";
            }
            else
            {
                string answer = head.value;
                p = head.Pri;
                head = head.back;
                Count--;

                return answer;
            }
        }

        public string DeQ()
        {
            if (Count == 0)
            {
                return "해당 큐는 비었습니다";
            }
            else
            {
                string answer = head.value;
                head = head.back;
                Count--;

                return answer;
            }
        }

        public string Peek()
        {
            return head.value;
        }

        public void PrintAllData()
        {
            if (Count != 0)
            {
                priNode data = head;
                while (data != null)
                {
                    Console.WriteLine("데이터: {0}, 우선순위: {1}",data.value,data.Pri);
                    data = data.back;
                }
            }
            else
            {
                Console.WriteLine("해당 큐는 비었습니다");
                return;
            }

        }


    }
}
