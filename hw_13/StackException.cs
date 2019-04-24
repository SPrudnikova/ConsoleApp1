using System;

namespace hw_13
{
    class StackException : Exception
    {
        public StackException()
        {
        }

        public StackException(string message)
            : base(message)
        {
        }

        public StackException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
