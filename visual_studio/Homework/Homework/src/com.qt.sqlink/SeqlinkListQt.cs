using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src.com.qt.sqlink
{
    class SeqlinkListQt<T> : IListQT<T>
    {
        private SeqlinkNode<T> HeadNode;

        public SeqlinkListQt()
        {
            HeadNode = null;
        }

        public int GetLength()
        {
            int length = 0;
            SeqlinkNode<T> p = HeadNode;
            while (p != null)
            {
                length++;
                p = p.Next;
            }
            return length;
        }

        public void Clear()
        {
            HeadNode = null;
        }

        public bool IsEmpty()
        {
            return HeadNode == null;
        }

        public void Append(T item)
        {
            SeqlinkNode<T> q= new SeqlinkNode<T>(item);
            SeqlinkNode<T> p= new SeqlinkNode<T>();

            if (HeadNode == null)
            {
                HeadNode = q;
                return;
            }

            p = HeadNode;
            while (p.Next != null)
            {
                p = p.Next;
            }

            p.Next = q;
        }

        public void Insert(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("LinkList is empty or position is error!");
                return;
            }
            if (i == 1)
            {
                SeqlinkNode<T> q = new SeqlinkNode<T>(item);
                q.Next = HeadNode;
               HeadNode = q;
                return;
            }
            SeqlinkNode<T> p = HeadNode;
            SeqlinkNode<T> r = new SeqlinkNode<T>();
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                r = p;
                p = p.Next;
            }
            if (j == i)
            {
                SeqlinkNode<T> q = new SeqlinkNode<T>(item);
                q.Next = p;
                r.Next = q;
            }
            else
            {
                Console.WriteLine("Positon is error!");
            }
            return;
        }

        public T Delete(int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("LinkList is empty or position is error!");
                return default(T);
            }

            SeqlinkNode<T> q = new SeqlinkNode<T>();
            if (i == 1)
            {
                q = HeadNode;
                HeadNode = HeadNode.Next;
                return q.Data;
            }

            SeqlinkNode<T> p = HeadNode;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                q = p;
                p = p.Next;
            }
            if (j == i)
            {
                q = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("Position is error!");
                return default(T);
            }
        }

        public T GetElem(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linklist is empty!");
                return default(T);
            }

            SeqlinkNode<T> p = HeadNode;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                p = p.Next;
            }
            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("Position is error!");
                return default(T);
            }
        }

        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("LinkList is empty!");
                return -1;
            }

            SeqlinkNode<T> p = HeadNode;
            int i = 1;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                ++i;
                p = p.Next;
            }
            return i;
        }

        public void Reverse()
        {
            SeqlinkNode<T> p = HeadNode;
            SeqlinkNode<T> q = new SeqlinkNode<T>();
            SeqlinkNode<T> R = new SeqlinkNode<T>();
            while (p != null)
            {
                q = p;
                p = p.Next;
                q.Next = R.Next;
                R.Next = q;
            }
            HeadNode = R.Next;
            R = null;
        }

        public void Print()
        {
            SeqlinkNode<T> p = HeadNode;
            if (p != null)
            {
                while (p != null)
                {
                    Console.Write(p.Data + "\n");
                    p = p.Next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("LinkList is empty!");
            }
        }
    }
}