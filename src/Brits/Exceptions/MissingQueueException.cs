using System;

namespace Brits
{
    /// <summary>
    /// Exception that is thrown when the Queue property is not set on a <see cref="Message"/> instance.
    /// </summary>
    public class MissingQueueException : Exception
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="MissingQueueException"/> class.
        /// </summary>
        /// <param name="obj">The type of object (Dispatchable or Receivable).</param>
        public MissingQueueException(string obj) : base($"{obj} object is missing its Queue property.")
        {
        }
    }
}
