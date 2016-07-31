using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src.com.qt.sqlink
{
    class SeqlinkNode<T>
    {
        private T data;
        private SeqlinkNode<T> next;

        public T Data
        {
            set { data = value; }
            get { return data; }
        }
        public SeqlinkNode<T> Next
        {
            set { next = value; }
            get { return next; }
        }

        public SeqlinkNode(T val, SeqlinkNode<T> p)
        {
            data = val;
            next = p;
        }

        public SeqlinkNode(SeqlinkNode<T> p)
        {
            next = p;
        }

        public SeqlinkNode(T val)
        {
            data = val;
            next = null;
        }

        public SeqlinkNode()
        {
            data = default(T);
            next = null;
        }
    }
}