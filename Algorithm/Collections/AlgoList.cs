using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Collections
{
    public class AlgoList<T> : IList<T>
    {

        const int DefaultSize = 5;
        public static int _capacity;
        public int Capacity => _capacity;
        public int Count { get; private set; } = 0;
        public bool IsReadOnly { get; }
        private T[] _items;


        public AlgoList()
        {
            _capacity = DefaultSize;
            _items = new T[_capacity];
        }

        public AlgoList(int capacity)
        {
            _capacity = capacity;
            _items = new T[_capacity];
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((ICollection<T>)_items).GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public AlgoListEnumerator GetEnumerator()
        {
            return new AlgoListEnumerator(_items);
        }

        public void Add(T item)
        {
            if (Count == _capacity)
            {
                IncreaseCapacity();
            }
            Insert(Count, item);
            Count++;
        }

        public void IncreaseCapacity()
        {
            _capacity = (_capacity * 2);

            _items.CopyTo(_items = new T[_capacity], 0);

        }

        public void Insert(int index, T item)
        {
            _items[index] = item;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) > -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ICollection<T> arrayCollection = array;
            int availableSpace = arrayCollection.Count - array.Length;

            if (availableSpace >= Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    array[arrayIndex] = _items[i];
                    arrayIndex++;
                }
            }
            else
            {
                throw new Exception("The array that's being copyied into doesn't have enough space");
            }


        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {

            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals((item)))
                {
                    return i;
                }
            }

            return -1;
        }


        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        #region IEnumerator Implementation

        public class AlgoListEnumerator : IEnumerator
        {
            private readonly T[] _items;
            private int _capacity { get; } = 0;

            public AlgoListEnumerator(T[] items)
            {
                _items = items;
                _capacity = items.Length;

            }

            public bool MoveNext()
            {
                _position++;
                return (_position < _capacity);
            }

            private int _position = -1;

            public void Reset()
            {
                _position = -1;
            }

            public object Current => _items[_position];
        }

        #endregion

    }
}
