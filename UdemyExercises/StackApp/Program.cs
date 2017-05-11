using System;
using System.Collections.Generic;

namespace StackApp
{
    class Program
    {
        static void Main (string[] args)
        {
            Stack myStack = new Stack(5);

   

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            Console.ReadKey();
        }
    }
}
