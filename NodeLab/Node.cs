using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NodeLab
{
    public class DoubleNode
    {
        private int info; private DoubleNode next; private DoubleNode prev;
        public int Info { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Prev { get; set; }

        public DoubleNode() { }

        public DoubleNode(int info)
        {
            Info = info;
        }

        public DoubleNode(int info, DoubleNode next, DoubleNode prev)
        {
            Info = info; Next = next; Prev = prev;
        }
    }

    public class CycleDoubleLinkedList
    {
        private DoubleNode head;

        public CycleDoubleLinkedList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }

        public void Create(int[] data)
        {
            DoubleNode p;
            for (int i = 0; i < data.Length; i++)
            {
                p = new DoubleNode(data[i]);
                p.Next = head;
                p.Prev = head.Prev;
                head.Prev.Next = p;
                head.Prev = p;
            }
        }

        public void InsertBeforeFirst(int data)
        {
            DoubleNode node = new DoubleNode(data);
            node.Next = head.Next;
            node.Prev = head;
            head.Next.Prev = node;
            head.Next = node;
        }

        public void InsertLast(int data)
        {
            DoubleNode node = new DoubleNode(data);
            node.Next = head;
            node.Prev = head.Prev;
            head.Prev.Next = node;
            head.Prev = node;
        }

        public void InsertCustom(int data, int position, out string errorMessage)
        {
            errorMessage = "";
            DoubleNode newNode = new DoubleNode(data);

            if (position < 1)
            {
                errorMessage = "Неверная позиция";
            }
            else
            {
                if (position == 1)
                {
                    newNode.Next = head.Next;
                    newNode.Prev = head;
                    head.Next.Prev = newNode;
                    head.Next = newNode;
                }
                else
                {
                    DoubleNode current = head.Next;
                    int index = 1;

                    while (current != head && index < position)
                    {
                        current = current.Next;
                        index++;
                    }

                    if (index != position)
                    {
                        errorMessage = "Позиция вне диапазона";
                    }
                    else
                    {
                        newNode.Next = current;
                        newNode.Prev = current.Prev;
                        current.Prev.Next = newNode;
                        current.Prev = newNode;
                    }
                }
            }
        }

        public void DeleteFirst()
        {
            if (head.Next != head)
            {
                head.Next = head.Next.Next;
                head.Next.Prev = head;
            }
        }

        public void DeleteLast()
        {
            if (head.Prev != head)
            {
                head.Prev = head.Prev.Prev;
                head.Prev.Next = head;
            }
        }

        public void DeleteCustom(int position, out string errorMessage)
        {
            errorMessage = "";

            if (position < 1)
            {
                errorMessage = "Неверная позиция";
            }
            else
            {
                DoubleNode current = head.Next;
                int index = 1;

                while (current != head && index < position)
                {
                    current = current.Next;
                    index++;
                }

                if (current == head)
                {
                    errorMessage = "Позиция вне диапазона";
                }
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
            }
        }

        public void DeleteBetween(int value1, int value2, out string errorMessage)
        {
            errorMessage = "";

            DoubleNode left = Find(value1);

            if (left == null)
            {
                errorMessage = "Левая граница не найдена";
            }
            else
            {
                DoubleNode right = Find(value2);

                if (right == null)
                {
                    errorMessage = "Правая граница не найдена";
                }
                else
                {
                    DoubleNode p = left.Next;
                    bool isCorrect = false;

                    while (p != head && p != right)
                    {
                        p = p.Next;
                    }

                    if (p == right)
                    {
                        if (left.Next == right)
                        {
                            errorMessage = "Между границами нет элементов";
                        }
                        else
                        {
                            p = left.Next;
                            while (p != right)
                            {
                                p.Prev.Next = p.Next;
                                p.Next.Prev = p.Prev;
                                p = p.Next;
                            }

                            left.Next = right;
                            right.Prev = left;
                        }
                    }
                    else
                    {
                        errorMessage = "Правая граница должна находиться после левой";
                    }
                }
            }
        }
        public void Clear()
        {
            head.Next = head;
            head.Prev = head;
        }

        public void Destroy()
        {
            head = null;
        }

        public DoubleNode Find(int value)
        {
            DoubleNode result = null;
            DoubleNode p = head.Next;

            while (p != head)
            {
                if (p.Info == value)
                {
                    result = p;
                }

                p = p.Next;
            }

            return result;
        }

        public void PrintListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            DoubleNode p = head.Next;
            while (p != head)
            {
                listBox.Items.Add(p.Info);
                p = p.Next;
            }
        }
    }
}
