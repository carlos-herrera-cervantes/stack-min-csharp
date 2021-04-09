using System.Collections.Generic;

namespace StackMinConsoleApp.Models
{
    public class StackWithMin : Stack<int>
    {
        private Stack<int> stack2;

        public StackWithMin() => stack2 = new Stack<int>();

        /// <summary>Adds new element</summary>
        /// <param name="value">Integer</param>
        /// <returns>Void</returns>
        public new void Push(int value)
        {
            if (value <= GetMinimum()) stack2.Push(value);
            base.Push(value);
        }

        /// <summary>Extracts the last element</summary>
        /// <returns>Integer</returns>
        public new int Pop()
        {
            int value = base.Pop();

            if (value == GetMinimum()) stack2.Pop();
            return value;
        }

        /// <summary>Returns the minimum value in the stack</summary>
        /// <returns>Integer</returns>
        public int GetMinimum()
        {
            if (stack2.Count == 0) return int.MaxValue;
            return stack2.Peek();
        }
    }
}