using System;
using System.Collections.Generic;

namespace StackApp
{
    public class Stack
    {
        private readonly List<Object> _contents;

        public Stack (int capatity)
        {
            _contents = new List<Object>(capatity);
        }

        public void Push(Object item)
        {
            if (item == null)
                throw new InvalidOperationException("You cant push null to the list!");

            if (_contents.Count == _contents.Capacity)
                throw new StackOverflowException("Stack is full");

            _contents.Add(item);
        }

        public Object Pop()
        {
            if (_contents.Count == 0)
                throw new InvalidOperationException("Stack is empty!");

            Object popItem = _contents[_contents.Count - 1];
            _contents.RemoveAt(_contents.Count - 1);

            return popItem;
        }

        public void Clear()
        {
            _contents.Clear();
        }
    }
}
