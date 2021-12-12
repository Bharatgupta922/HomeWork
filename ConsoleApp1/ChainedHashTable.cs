using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class ChainedHashTable<TKey, T> : IHashTable<TKey ,T>
    {
        private class HashItem
        {
            internal TKey key;
            internal T data;
            internal HashItem next;
            public HashItem(TKey key, T data)
            {
                this.key = key;
                this.data = data;
                this.next = null;
            }
        }

        HashItem[] _table;
        private readonly int _size;
       public ChainedHashTable(int size)
        {
           this._size = size;
        }

        private int HashFunction(TKey key)
        {
            var value = Int32.Parse(key.ToString());

            return value % (_size);
        }

        public T Store(TKey key, T item)
        {
            //get address
            var address = HashFunction(key);

            //
            var newItem = new HashItem(key, item);

        }

        public T Retrieve(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Exists(TKey key)
        {
            var address = HashFunction(key);
            var item = _table[address];

            while (item != null && item.key.Equals(key))
                item = item.next;

            return item == null ? false : true;


        }

        public T remove(TKey key)
        {
            throw new NotImplementedException();
        }
    }
}
