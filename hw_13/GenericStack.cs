namespace hw_13
{
    class GenericStack<T>
    {
        public readonly int capacity;
        public int stackSize { get; set; }
        private T[] stack { get; set; }

        public GenericStack()
        {
            capacity = 10;
            stackSize = 0;
            stack = new T[capacity];
        }

        public void Push(T item)
        {
            if (capacity == stackSize)
            {
                throw new StackException("Stack overflow");
            }

            stack[stackSize] = item;
            stackSize += 1;
        }

        public T Pop()
        {
            if (stackSize == 0)
            {
                throw new StackException("Stack is empty");
            }

            T item = stack[stackSize - 1];
            stack[stackSize - 1] = default(T);
            stackSize -= 1;

            return item;
        }

        public T Peek()
        {
            return stack[stackSize - 1];
        }
    }
}
