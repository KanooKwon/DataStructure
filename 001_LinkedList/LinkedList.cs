using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_LinkedList
{
    class Node
    {
        public Node Front;
        public Node Back;
        public string Value;

        public Node(string V)
        {
            Value = V;
        }
    }

    class LinkedList
    {
        public Node Head;
        public Node Last;
        public int Count;

        public LinkedList(string v)
        {
            Node n = new Node(v);
            Head = n;
            Last = Head;
            Count = 1;
        }
    }

    class LinkedListMng
    {
        public LinkedList theList;

        public LinkedListMng(string v)
        {
            LinkedList newone = new LinkedList(v);
            theList = newone;
        }

        public void AddData(string v)
        {
            Node data = new Node(v);
            if (theList.Head == null)
            {
                theList.Head = data;
                theList.Last = data;
                theList.Count += 1;
                return;
            }
            else
            {
                theList.Last.Back = data;
                data.Front = theList.Last;
                theList.Last = data;
                theList.Count += 1;
                return;
            }
        }

        /// <summary>
        /// 인덱싱에 의한 순서가 아닌 실제 순서에 따른 삽입
        /// </summary>
        /// <param name="v"></param>
        /// <param name="idx"></param>
        public void InsertData(string v, int idx)
        {
            if (theList.Count >= idx && theList.Count != 0)
            {
                Node data = new Node(v);
                if (idx <= 1)
                {
                    Node temp;
                    temp = theList.Head;
                    theList.Head = data;
                    theList.Head.Back = temp;
                    temp.Front = theList.Head;
                    theList.Count++;
                }
                else
                {
                    Node insert;
                    if (idx <= theList.Count / 2)
                    {
                        insert = theList.Head;

                        for (int i = 0; i < idx - 1; i++)
                        {
                            insert = insert.Back;
                        }

                        insert.Front.Back = data;
                        data.Front = insert.Front;
                        data.Back = insert;
                        insert.Front = data;
                        theList.Count++;

                    }
                    else
                    {
                        insert = theList.Last;

                        for (int i = 0; i < theList.Count - idx; i++)
                        {
                            insert = insert.Front;
                        }

                        insert.Front.Back = data;
                        data.Front = insert.Front;
                        data.Back = insert;
                        insert.Front = data;
                        theList.Count++;
                    }
                }
            }
            else
            {
                AddData(v);
            }

        }

        public void Contain(string v)
        {
            Node result = FindDataFromFront(v);

            if (result != null)
            {
                Console.WriteLine("검색 요청하신 데이터 {0} 은(는) 해당 리스트에 존재합니다", v);
            }
            else
            {
                Console.WriteLine("검색 요청하신 데이터 {0} 은(는) 해당 리스트에 존재하지 않습니다", v);
            }
        }

        public Node FindDataFromFront(string data)
        {
            Node answer = null;
            Node search = theList.Head;

            while (search != null)
            {
                if (search.Value == data)
                {
                    answer = search;
                    return answer;
                }
                search = search.Back;
            }

            return answer;
        }

        public Node FindDataFromBack(string data)
        {
            Node answer = null;
            Node search = theList.Last;

            while (search != null)
            {
                if (search.Value == data)
                {
                    answer = search;
                    return answer;
                }
                search = search.Front;
            }

            return answer;
        }

        public string DeleteData(string value)
        {
            Node delete = FindDataFromFront(value);
            if (delete != null)
            {
                if (delete == theList.Head)
                {
                    theList.Head = theList.Head.Back;
                    theList.Head.Front = null;
                    theList.Count--;
                }
                else if (delete == theList.Last)
                {
                    theList.Last = theList.Last.Front;
                    theList.Last.Back = null;
                    theList.Count--;
                }
                else
                {
                    delete.Front.Back = delete.Back;
                    delete.Back.Front = delete.Front;
                    theList.Count--;
                }
                return "삭제되었습니다\n";
            }
            else
            {
                return "해당 데이터는 리스트에 없습니다\n";
            }
        }

        public void PrintAllData()
        {
            Node data = theList.Head;

            if(data == null)
            {
                Console.WriteLine("해당 리스트는 비어있습니다");
            }

            Console.Write("전체 데이터 목록: ");
            while (data != null)
            {
                if(data.Back != null)
                {
                    Console.Write(data.Value + ", ");
                    data = data.Back;
                }
                else
                {
                    Console.WriteLine(data.Value);
                    data = data.Back;
                }
                
            }
        }
    }
}
