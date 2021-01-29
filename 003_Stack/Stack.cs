using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Stack
{
    class Node
    {
        public string value;
        public Node up;
        public Node down;

        public Node(string v)
        {
            value = v;
        }
    }

    class Stack
    {
        public Node Head;
        public int Count;

        public Stack(string v)
        {
            Head = new Node(v);
            Count = 1;
        }

        public void Push(string v)
        {
            Node newone = new Node(v);
            if(Count != 0)
            {
                Head.up = newone;
                newone.down = Head;
                Head = newone;
                Count++;
            }
            else
            {
                Head = newone;
                Count++;
            }
        }

        public string Pop()
        {
            string answer = Head.value;
            if (Head.down != null)
            {
                Head = Head.down;
                Head.up = null;
            }
            else
            {
                Head = null;
            }
            Count--;
            return answer;
        }

        public string Peek()
        {
            return Head.value;
        }

        public void PrintAllData()
        {
            if(Count != 0)
            {
                Node data = Head;
                while (data != null)
                {
                    Console.WriteLine(data.value);
                    data = data.down;
                }
            }
            else
            {
                Console.WriteLine("해당 스택은 비었습니다");
            }

        }
    }
}
