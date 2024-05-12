using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public interface IStack<E>
    {
        int Count { get; }
        
        bool IsEmpty { get; }

        void Push(E e);

        E Pop();

        E Peek();
    }
}
