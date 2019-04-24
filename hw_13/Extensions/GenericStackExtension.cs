namespace hw_13.Extensions
{
    static class GenericStackExtension
    {
        public static int GetRestCapacity<T>(this GenericStack<T> stack)
        {
            return stack.capacity - stack.stackSize;
        }
    }
}
