namespace hw_13.Extensions
{
    static class StackExtension
    {
        public static int GetRestCapacity (this Stack stack)
        {
            return stack.capacity - stack.stackSize;
        }
    }
}
