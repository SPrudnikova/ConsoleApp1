using System;
using hw_13.Extensions;

namespace hw_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Console.WriteLine(stack.GetRestCapacity());

            GenericStack<int> genericStack = new GenericStack<int>();
            genericStack.Push(1);
            genericStack.Push(2);
            genericStack.Push(3);
            genericStack.Pop();
            Console.WriteLine(genericStack.GetRestCapacity());

            Console.Read();
        }
    }
}
