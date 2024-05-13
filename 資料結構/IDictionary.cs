using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public interface Idictionary<Key,Value>
    {
        void Add(Key key, Value value);
        void Remove(Key key);
        bool ContainsKey(Key key);

        Value Get(Key key); 

        void Set(Key key, Value value);

        int Count { get; }

        bool IsEmpty { get; }
    }
}
