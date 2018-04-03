using System.Collections;

namespace Algorithm.Collections
{
    public partial class AlgoList<T>
    {
        #region IEnumerator Implementation

        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="System.Collections.Generic.IList{T}" />
        public class AlgoListEnumerator : IEnumerator
        {
            /// <summary>
            /// The items
            /// </summary>
            private readonly T[] _items;
            /// <summary>
            /// Gets the capacity.
            /// </summary>
            /// <value>
            /// The capacity.
            /// </value>
            private int _capacity { get; } = 0;

            /// <summary>
            /// Initializes a new instance of the <see cref="AlgoListEnumerator"/> class.
            /// </summary>
            /// <param name="items">The items.</param>
            public AlgoListEnumerator(T[] items)
            {
                _items = items;
                _capacity = items.Length;

            }

            /// <summary>
            /// Advances the enumerator to the next element of the collection.
            /// </summary>
            /// <returns>
            ///   <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.
            /// </returns>
            public bool MoveNext()
            {
                _position++;
                return (_position < _capacity);
            }

            /// <summary>
            /// The position
            /// </summary>
            private int _position = -1;

            /// <summary>
            /// Sets the enumerator to its initial position, which is before the first element in the collection.
            /// </summary>
            public void Reset()
            {
                _position = -1;
            }

            /// <summary>
            /// Gets the element in the collection at the current position of the enumerator.
            /// </summary>
            public object Current => _items[_position];
        }

        #endregion

    }
}
