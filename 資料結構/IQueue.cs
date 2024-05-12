using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public interface IQueue<E>
    {
        int Count { get; }

        bool IsEmpty { get; }

        E Peek();

        E Dequeue();

        void Enqueue(E e);
    }
}
