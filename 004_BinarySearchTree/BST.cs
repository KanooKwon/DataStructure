using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_BinarySearchTree
{
    class Node
    {
        public int value;
        public Node Parent;
        public Node Left;
        public Node Right;

        public Node(int v)
        {
            value = v;
        }
    }

    class BST
    {
        Node Root;

        public BST(int v)
        {
            Root = new Node(v);
        }

        // 같으면 오른쪽
        public void Add(int num)
        {
            Node compare = Root;

            while (true)
            {
                if (compare.value <= num)
                {
                    if (compare.Right == null)
                    {
                        Node right = new Node(num);
                        compare.Right = right;
                        right.Parent = compare;
                        break;
                    }
                    else
                    {
                        compare = compare.Right;
                    }
                }
                else
                {
                    if (compare.Left == null)
                    {
                        Node left = new Node(num);
                        compare.Left = left;
                        left.Parent = compare;
                        break;
                    }
                    else
                    {
                        compare = compare.Left;
                    }
                }
            }
        }

        public void Delete(int num)
        {
            Node target = Search(num);
            if (target != null)
            {
                // leaf 노드 일때
                if (target.Left == null && target.Right == null)
                {
                    // 타겟이 루트노드라면
                    if (target == Root)
                    {
                        Root = null;
                        return;
                    }

                    if (target.Parent.Left == target)
                    {
                        target.Parent.Left = null;
                    }
                    else
                    {
                        target.Parent.Right = null;

                    }
                    target.Parent = null;
                }
                // 왼쪽 노드만 있을때
                else if (target.Right == null)
                {
                    // target이 루트 노드일때
                    if (target == Root)
                    {
                        Root = target.Left;
                        Root.Parent = null;
                        return;
                    }
                    // target이 루트노드가 아닐때
                    else
                    {
                        // 부모 노드의 왼쪽 노드일때
                        if (target == target.Parent.Left)
                        {
                            target.Parent.Left = target.Left;
                            target.Left.Parent = target.Parent;
                            return;
                        }
                        // 부모노드의 오른쪽 노드일때
                        else
                        {
                            target.Parent.Right = target.Left;
                            target.Left.Parent = target.Parent;
                            return;
                        }
                    }
                }
                // 오른쪽 노드만 있을때
                else if (target.Left == null)
                {
                    // target이 루트 노드일때
                    if (target == Root)
                    {
                        Root = target.Right;
                        Root.Parent = null;
                        return;
                    }
                    // target이 루트노드가 아닐때
                    else
                    {
                        // 부모 노드의 왼쪽 노드일때
                        if (target == target.Parent.Left)
                        {
                            target.Parent.Left = target.Right;
                            target.Right.Parent = target.Parent;
                            return;
                        }
                        // 부모노드의 오른쪽 노드일때
                        else
                        {
                            target.Parent.Right = target.Right;
                            target.Right.Parent = target.Parent;
                            return;
                        }
                    }
                }
                // 좌우 노드가 모두 있을때
                else
                {
                    // 왼쪽 노드들중 가장 큰값을 target의 자리로 
                    Node leftMax = target.Left;

                    // 가장 큰값이 나올때까지 내려가기
                    while (leftMax.Right != null)
                    {
                        leftMax = leftMax.Right;
                    }

                    // leftMax가 아무노드도 가지고 있지 않을때
                    if (leftMax.Left == null)
                    {
                        leftMax.Parent.Right = null;

                        // 타겟이 루트노드라면
                        if (target == Root)
                        {
                            leftMax.Parent = null;
                            leftMax.Left = target.Left;
                            leftMax.Right = target.Right;
                            Root = leftMax;
                            return;
                        }
                        else
                        {
                            // target의 좌우위치 파악
                            // 부모노드의 왼쪽 노드일때
                            if (target.Parent.Left == target)
                            {
                                // 1. leftMax가 target자리로
                                target.Parent.Left = leftMax;
                                leftMax.Parent = target.Parent;

                                // 2. target의 왼쪽 자식과 연결
                                leftMax.Left = target.Left;
                                target.Left.Parent = leftMax;

                                // 3. target의 오른쪽 자식과 연결
                                leftMax.Right = target.Right;
                                target.Right.Parent = leftMax;
                            }
                            // 부모노드의 오른쪽 노드일때
                            else
                            {
                                // 1. leftMax가 target자리로
                                target.Parent.Right = leftMax;
                                leftMax.Parent = target.Parent;

                                // 2. target의 왼쪽 자식과 연결
                                leftMax.Left = target.Left;
                                target.Left.Parent = leftMax;

                                // 3. target의 오른쪽 자식과 연결
                                leftMax.Right = target.Right;
                                target.Right.Parent = leftMax;
                            }
                        }
                    }

                    // leftMax가 왼쪽 노드를 가지고 있을때
                    else
                    {
                        // leftMax의 Parent가 target이라면 leftMax가 자식노드가 있어도 조정필요X
                        if (target == leftMax.Parent)
                        {
                            if (target == Root)
                            {
                                leftMax = Root;
                                leftMax.Parent = null;
                            }
                            else
                            {
                                // target의 좌우위치 파악
                                // 부모노드의 왼쪽 노드일때
                                if (target.Parent.Left == target)
                                {
                                    target.Parent.Left = leftMax;
                                    leftMax.Parent = target.Parent;
                                }
                                // 부모노드의 오른쪽 노드일때
                                else
                                {
                                    target.Parent.Right = leftMax;
                                    leftMax.Parent = target.Parent;
                                }
                            }
                        }

                        // leftMax의 자식노드 조정이 필요할때
                        else
                        {
                            // leftMax의 자식노드 이전
                            leftMax.Parent.Right = leftMax.Left;
                            leftMax.Left.Parent = leftMax.Parent;

                            if(target == Root)
                            {
                                leftMax.Left = Root.Left;
                                leftMax.Right = Root.Right;
                                Root = leftMax;
                                leftMax.Parent = null;
                            }
                            else
                            {
                                // leftMax target위치로
                                // target의 좌우위치 파악
                                // 부모노드의 왼쪽 노드일때
                                if (target.Parent.Left == target)
                                {
                                    // 1. leftMax가 target자리로
                                    target.Parent.Left = leftMax;
                                    leftMax.Parent = target.Parent;

                                    // 2. target의 왼쪽 자식과 연결
                                    leftMax.Left = target.Left;
                                    target.Left.Parent = leftMax;

                                    // 3. target의 오른쪽 자식과 연결
                                    leftMax.Right = target.Right;
                                    target.Right.Parent = leftMax;
                                }
                                // 부모노드의 오른쪽 노드일때
                                else
                                {
                                    // 1. leftMax가 target자리로
                                    target.Parent.Right = leftMax;
                                    leftMax.Parent = target.Parent;

                                    // 2. target의 왼쪽 자식과 연결
                                    leftMax.Left = target.Left;
                                    target.Left.Parent = leftMax;

                                    // 3. target의 오른쪽 자식과 연결
                                    leftMax.Right = target.Right;
                                    target.Right.Parent = leftMax;
                                }
                            }
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("데이터 {0}이(가) 트리에 없습니다", num);
                return;
            }
        }

        public Node Search(int num)
        {
            Node search = Root;

            while (search != null)
            {
                if (search.value == num)
                {
                    return search;
                }
                else if (search.value < num)
                {
                    search = search.Right;
                }
                else
                {
                    search = search.Left;
                }
            }
            return null;
        }
    }
}
