using System;

namespace hw_13
{
    class Stack
    {
        public readonly int capacity;
        public int stackSize { get; private set; }
        private object[] stack { get; set; }

        public Stack()
        {
            capacity = 10;
            stackSize = 0;
            stack = new object[capacity];
        }

        public void Push(object item)
        {
            if (capacity == stackSize)
            {
                throw new StackException("Stack overflow");
            }

            stack[stackSize] = item;
            stackSize += 1;
        }

        public object Pop()
        {
            if (stackSize == 0) {
                throw new StackException("Stack is empty");
            }

            object item = stack[stackSize - 1];
            stack[stackSize - 1] = null;
            stackSize -= 1;

            return item;
        }

        public object Peek()
        {
            return stack[stackSize - 1];
        }
    }
}
