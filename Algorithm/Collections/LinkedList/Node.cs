namespace Algorithm.Collections.LinkedList
{
    /// <summary>
    /// The node class defines a node in a linked list, and is made up of 3 properties: Data, Next, and Previous.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// The data
        /// </summary>
        public T Data;
        /// <summary>
        /// A pointer to the next node
        /// </summary>
        public Node<T> Next;
        /// <summary>
        /// A pointer to the previous node
        /// </summary>
        public Node<T> Previous;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }
}