namespace hw_13
{
    class GenericStack<T>
    {
        private const int capacity = 10;
        private T[] stack { get; set; }
        private int stackSize { get; set; }

        public GenericStack()
        {
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
