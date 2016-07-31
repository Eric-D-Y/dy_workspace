using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src.com.qt.sqlink
{
    interface IListQT<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Append(T item);
        void Insert(T item, int i);
        T Delete(int i);
        T GetElem(int i);
        int Locate(T value);
        void Reverse();
        void Print();
    }
}
