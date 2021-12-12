using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public  interface IHashTable<TKey , T>
    {
        public T Store(TKey key, T item);
        public T Retrieve(TKey key);
        public bool Exists(TKey key);
        public T remove(TKey key);
    }
}
