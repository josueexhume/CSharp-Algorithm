using System;

namespace Algorithm.Collections.LinkedList
{
    /// <summary>
    /// The NodeNotFoundException is thrown by the application when a node is not found
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class NodeNotFoundException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Algorithm.Collections.LinkedList.NodeNotFoundException" /> class.
        /// </summary>
        public NodeNotFoundException()
        {

        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Algorithm.Collections.LinkedList.NodeNotFoundException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NodeNotFoundException(string message) : base(message)
        {

        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Algorithm.Collections.LinkedList.NodeNotFoundException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public NodeNotFoundException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}