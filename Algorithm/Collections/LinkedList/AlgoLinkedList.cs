using System;


namespace Algorithm.Collections.LinkedList
{

    /// <summary>
    /// The AlgoLinkedList class defines a linked list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AlgoLinkedList<T>
    {
        /// <summary>
        /// The head node
        /// </summary>
        public Node<T> HeadNode;
        /// <summary>
        /// The tail node
        /// </summary>
        public Node<T> TailNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlgoLinkedList{T}"/> class.
        /// </summary>
        public AlgoLinkedList()
        {
            HeadNode = null;
            TailNode = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlgoLinkedList{T}"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        public AlgoLinkedList(Node<T> node)
        {
            HeadNode = node;
            TailNode = node;
        }

        /// <summary>
        /// Inserts a new node the after an old node
        /// </summary>
        /// <param name="oldNode">The old node.</param>
        /// <param name="newNode">The new node.</param>
        /// <returns></returns>
        public Node<T> InsertAfter(Node<T> oldNode, Node<T> newNode)
        {
            newNode.Previous = oldNode;

            if (oldNode.Next == null)
            {
                oldNode.Next = newNode;
                TailNode = newNode;
            }
            else
            {
                Node<T> tempNodeNext = oldNode.Next;

                oldNode.Next = newNode;
                newNode.Next = tempNodeNext;
                tempNodeNext.Previous = newNode;

            }

            return newNode;
        }

        /// <summary>
        /// Inserts a new node the before an old node.
        /// </summary>
        /// <param name="oldNode">The old node.</param>
        /// <param name="newNode">The new node.</param>
        /// <returns></returns>
        public Node<T> InsertBefore(Node<T> oldNode, Node<T> newNode)
        {
            newNode.Next = oldNode;

            if (oldNode.Previous == null)
            {
                oldNode.Previous = newNode;
                HeadNode = newNode;
            }
            else
            {
                Node<T> tempNodePrevious = oldNode.Previous;

                oldNode.Previous = newNode;
                newNode.Previous = tempNodePrevious;
                tempNodePrevious.Next = newNode;

            }

            return newNode;
        }

        /// <summary>
        /// Inserts a node the beginning of the nodelist.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        /// <returns></returns>
        public Node<T> InsertBeginning(Node<T> newNode)
        {
            if (HeadNode == null)
            {
                HeadNode = newNode;
                TailNode = newNode;
            }
            else
            {
                InsertBefore(HeadNode, newNode);
            }

            return newNode;
        }

        /// <summary>
        /// Inserts a node the end of the nodelist.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        /// <returns></returns>
        public Node<T> InsertEnd(Node<T> newNode)
        {
            if (TailNode == null)
            {
                InsertBeginning(newNode);
            }
            else
            {
                InsertAfter(TailNode, newNode);
            }

            return newNode;
        }

        /// <summary>
        /// Removes a specified node from the list.
        /// </summary>
        /// <param name="nodeToRemove">The node to remove.</param>
        /// <exception cref="Algorithm.Collections.LinkedList.NodeNotFoundException">Node does not Exist</exception>
        public void Remove(Node<T> nodeToRemove)
        {
            if(NodeExist(nodeToRemove)) throw  new NodeNotFoundException("Node does not Exist");

            if (nodeToRemove.Previous == null)
            {
                HeadNode = nodeToRemove.Next;
            }
            else
            {
                nodeToRemove.Previous.Next = nodeToRemove.Next;
            }

            if (nodeToRemove.Next == null)
            {
                TailNode = nodeToRemove.Previous;
            }
            else
            {
                nodeToRemove.Next.Previous = nodeToRemove.Previous;
            }
        }

        /// <summary>
        /// Checks to see if a Node exist.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public bool NodeExist(Node<T> node)
        {
            bool foundNode = false;
            Node<T> tempNode = HeadNode;

            if (HeadNode == node || TailNode == node)
            {
                return true;
            }
            else
            {
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                    if (tempNode != node) continue;
                    foundNode = true;
                    break;
                }

            }

            return foundNode;
        }


    }


}
